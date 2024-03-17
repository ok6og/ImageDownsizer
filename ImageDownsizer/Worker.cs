using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ImageDownsizer
{
    public class Worker
    {

        public static Bitmap[] SplitBitmap1(Bitmap src)
        {
            Bitmap[] divided = new Bitmap[4];

            int partWidth = src.Width / 2;
            int partHeight = src.Height / 2;

            // Create each segment directly within the loop
            for (int i = 0; i < divided.Length; i++)
            {
                int startX = (i % 2) * partWidth;
                int startY = (i / 2) * partHeight;

                divided[i] = new Bitmap(partWidth, partHeight, src.PixelFormat);

                Rectangle srcRect = new Rectangle(startX, startY, partWidth, partHeight);
                Rectangle dstRect = new Rectangle(0, 0, partWidth, partHeight);

                // Lock bits for both source and destination bitmaps
                BitmapData srcData = src.LockBits(srcRect, ImageLockMode.ReadOnly, src.PixelFormat);
                BitmapData dstData = divided[i].LockBits(dstRect, ImageLockMode.WriteOnly, src.PixelFormat);

                // Calculate stride (bytes per row) for source and destination bitmaps
                int srcStride = srcData.Stride;
                int dstStride = dstData.Stride;

                // Create byte arrays for source and destination buffers
                byte[] srcBuffer = new byte[srcStride * partHeight];
                byte[] dstBuffer = new byte[dstStride * partHeight];

                // Copy pixel data row by row
                for (int y = 0; y < partHeight; y++)
                {
                    // Copy row from source bitmap to source buffer
                    Marshal.Copy(IntPtr.Add(srcData.Scan0, y * srcStride), srcBuffer, 0, srcStride);
                    // Copy row from source buffer to destination buffer
                    Array.Copy(srcBuffer, 0, dstBuffer, y * dstStride, dstStride);
                }

                // Copy pixel data from destination buffer to destination bitmap
                Marshal.Copy(dstBuffer, 0, IntPtr.Add(dstData.Scan0, 0), dstBuffer.Length);

                // Unlock bits after processing
                src.UnlockBits(srcData);
                divided[i].UnlockBits(dstData);
            }

            return divided;
        }
        //public static Bitmap[] SplitBitmap1(Bitmap src)
        //{
        //    Bitmap[] divided = new Bitmap[4];

        //    int partWidth = src.Width / 2;
        //    int partHeight = src.Height / 2;

        //    divided[0] = src.Clone(new Rectangle(0, 0, partWidth, partHeight), src.PixelFormat);
        //    divided[1] = src.Clone(new Rectangle(partWidth, 0, partWidth, partHeight), src.PixelFormat);
        //    divided[2] = src.Clone(new Rectangle(0, partHeight, partWidth, partHeight), src.PixelFormat);
        //    divided[3] = src.Clone(new Rectangle(partWidth, partHeight, partWidth, partHeight), src.PixelFormat);

        //    return divided;
        //}

        //public static Bitmap[] SplitBitmap(Bitmap src)
        //{
        //    int numParts = Environment.ProcessorCount;
        //    Bitmap[] divided = new Bitmap[numParts];

        //    int partWidth = src.Width / (int)Math.Ceiling(Math.Sqrt(numParts));
        //    int partHeight = src.Height / (int)Math.Ceiling((double)numParts / Math.Ceiling(Math.Sqrt(numParts)));

        //    int index = 0;
        //    for (int y = 0; y < Math.Ceiling((double)src.Height / partHeight); y++)
        //    {
        //        for (int x = 0; x < Math.Ceiling((double)src.Width / partWidth); x++)
        //        {
        //            divided[index] = src.Clone(new Rectangle(x * partWidth, y * partHeight, partWidth, partHeight), src.PixelFormat);
        //            index++;
        //            if (index >= numParts)
        //                break;
        //        }
        //    }

        //    return divided;
        //}

        public static Bitmap AssembleBitmap(Bitmap[] parts)
        {
            if (parts == null || parts.Length == 0)
                throw new ArgumentException("No parts provided.");

            int partsX = (int)Math.Ceiling(Math.Sqrt(parts.Length));
            int partsY = (int)Math.Ceiling((double)parts.Length / partsX);

            int totalWidth = partsX * parts[0].Width;
            int totalHeight = partsY * parts[0].Height;

            Bitmap assembledBitmap = new Bitmap(totalWidth, totalHeight, parts[0].PixelFormat);

            int currentPartIndex = 0;

            // Iterate through each row of parts
            for (int row = 0; row < partsY; row++)
            {
                // Iterate through each column of parts
                for (int col = 0; col < partsX; col++)
                {
                    // Get the current part
                    Bitmap currentPart = parts[currentPartIndex];

                    // Copy the pixel data from the current part to the assembled bitmap
                    CopyBitmapData(currentPart, assembledBitmap, col * currentPart.Width, row * currentPart.Height);

                    // Move to the next part
                    currentPartIndex++;
                }
            }

            return assembledBitmap;
        }

        private static void CopyBitmapData(Bitmap sourceBitmap, Bitmap destinationBitmap, int destX, int destY)
        {
            // Lock the bits of the source and destination bitmaps
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadOnly, sourceBitmap.PixelFormat);
            BitmapData destData = destinationBitmap.LockBits(new Rectangle(destX, destY, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.WriteOnly, destinationBitmap.PixelFormat);

            try
            {
                // Calculate the number of bytes per row
                int bytesPerPixel = Image.GetPixelFormatSize(sourceBitmap.PixelFormat) / 8;
                int sourceStride = sourceData.Stride;
                int destStride = destData.Stride;

                // Allocate buffers for pixel data
                byte[] sourceBuffer = new byte[sourceStride * sourceData.Height];
                byte[] destBuffer = new byte[destStride * sourceData.Height];

                // Copy pixel data from source bitmap to buffer
                Marshal.Copy(sourceData.Scan0, sourceBuffer, 0, sourceBuffer.Length);

                // Copy pixel data from buffer to destination bitmap
                Marshal.Copy(sourceBuffer, 0, destData.Scan0, sourceBuffer.Length);
            }
            finally
            {
                // Unlock the bits of the source and destination bitmaps
                sourceBitmap.UnlockBits(sourceData);
                destinationBitmap.UnlockBits(destData);
            }
        }

        public static Bitmap ParallelResizing(Bitmap originalImage, double imageScale, Func<Bitmap, double, Bitmap> resizingMethod)
        {
            Bitmap[] bitmapParts = SplitBitmap1(originalImage);

            Task<Bitmap>[] tasks = new Task<Bitmap>[4];

            //for (int i = 0; i < bitmapParts.Length-1; i++)
            //{
            //    tasks[i] = Task.Run(() => resizingMethod(bitmapParts[i], imageScale));
            //}

            tasks[0] = Task.Run(() => resizingMethod(bitmapParts[0], imageScale));
            tasks[1] = Task.Run(() => resizingMethod(bitmapParts[1], imageScale));

            tasks[2] = Task.Run(() => resizingMethod(bitmapParts[2], imageScale));
            tasks[3] = Task.Run(() => resizingMethod(bitmapParts[3], imageScale));


            Task.WaitAll(tasks);

            var assembled = AssembleBitmap(bitmapParts);

            return assembled;
        }
    }
}

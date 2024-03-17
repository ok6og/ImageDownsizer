using ImageDownsizer.Algorithms;
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

            divided[0] = src.Clone(new Rectangle(0, 0, partWidth, partHeight), src.PixelFormat);
            divided[1] = src.Clone(new Rectangle(partWidth, 0, partWidth, partHeight), src.PixelFormat);
            divided[2] = src.Clone(new Rectangle(0, partHeight, partWidth, partHeight), src.PixelFormat);
            divided[3] = src.Clone(new Rectangle(partWidth, partHeight, partWidth, partHeight), src.PixelFormat);

            return divided;
        }

        public static Bitmap AssembleBitmap(Bitmap[] parts)
        {
            int partWidth = parts[0].Width;
            int partHeight = parts[0].Height;
            int width = partWidth * 2;
            int height = partHeight * 2;

            Bitmap combinedBitmap = new Bitmap(width, height);
            Rectangle combinedRect = new Rectangle(0, 0, width, height);
            BitmapData combinedData = combinedBitmap.LockBits(combinedRect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            IntPtr combinedPtr = combinedData.Scan0;
            int combinedStride = combinedData.Stride;
            int combinedBytes = Math.Abs(combinedStride) * height;
            byte[] combinedRGBValues = new byte[combinedBytes];

            Task[] tasks = new Task[4];

            for (int i = 0; i < 4; i++)
            {
                int index = i;
                tasks[i] = Task.Run(() =>
                {
                    Bitmap part = parts[index];

                    Rectangle partRect = new Rectangle(0, 0, partWidth, partHeight);
                    BitmapData partData = part.LockBits(partRect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                    IntPtr partPtr = partData.Scan0;
                    int partStride = partData.Stride;
                    int partBytes = Math.Abs(partStride) * partHeight;
                    byte[] partRGBValues = new byte[partBytes];
                    Marshal.Copy(partPtr, partRGBValues, 0, partBytes);

                    int destX = (index % 2) * partWidth;
                    int destY = (index / 2) * partHeight;

                    for (int y = 0; y < partHeight; y++)
                    {
                        int combinedOffset = (destY + y) * combinedStride + destX * 4;
                        int partOffset = y * partStride;

                        Array.Copy(partRGBValues, partOffset, combinedRGBValues, combinedOffset, partStride);
                    }

                    part.UnlockBits(partData);
                });
            }

            Task.WaitAll(tasks);
            Marshal.Copy(combinedRGBValues, 0, combinedPtr, combinedBytes);
            combinedBitmap.UnlockBits(combinedData);
            return combinedBitmap;
        }

        public static Bitmap ParallelResizing(Bitmap originalImage, double imageScale, Func<Bitmap, double, Bitmap> resizingMethod)
        {
            Bitmap[] bitmapParts = SplitBitmap1(originalImage);

            Task<Bitmap>[] tasks =
            [
                Task.Run(() => resizingMethod(bitmapParts[0], imageScale)),
                Task.Run(() => resizingMethod(bitmapParts[1], imageScale)),
                Task.Run(() => resizingMethod(bitmapParts[2], imageScale)),
                Task.Run(() => resizingMethod(bitmapParts[3], imageScale)),
            ];
            Task.WaitAll(tasks);

            Bitmap[] resizedParts = new Bitmap[4];
            for (int i = 0; i < 4; i++)
            {
                resizedParts[i] = tasks[i].Result;
            }
 
            return AssembleBitmap(resizedParts);
        }
    }
}

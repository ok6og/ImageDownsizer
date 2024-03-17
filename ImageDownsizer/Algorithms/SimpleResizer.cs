using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageDownsizer.Algorithms
{
    public class SimpleResizer
    {

        public static Bitmap ResizeImage(Bitmap originalImage, double scaleFactor)
        {
            int newWidth = (int)Math.Round(originalImage.Width * scaleFactor);
            int newHeight = (int)Math.Round(originalImage.Height * scaleFactor);

            Bitmap newImage = new Bitmap(newWidth, newHeight, originalImage.PixelFormat);

            BitmapData originalData = originalImage.LockBits(new Rectangle(0, 0, originalImage.Width, originalImage.Height), ImageLockMode.ReadOnly, originalImage.PixelFormat);
            BitmapData newData = newImage.LockBits(new Rectangle(0, 0, newWidth, newHeight), ImageLockMode.WriteOnly, newImage.PixelFormat);

            int bytesPerPixel = CalculateBytesPerPixel(originalImage.PixelFormat);

            int originalStride = originalData.Stride;
            int newStride = newData.Stride;

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int originalX = (int)Math.Round(x / scaleFactor);
                    int originalY = (int)Math.Round(y / scaleFactor);

                    originalX = Math.Min(originalX, originalImage.Width - 1);
                    originalY = Math.Min(originalY, originalImage.Height - 1);

                    IntPtr originalPixelPtr = IntPtr.Add(originalData.Scan0, (originalY * originalStride) + (originalX * bytesPerPixel));
                    IntPtr newPixelPtr = IntPtr.Add(newData.Scan0, (y * newStride) + (x * bytesPerPixel));

                    byte[] pixelData = new byte[bytesPerPixel];
                    Marshal.Copy(originalPixelPtr, pixelData, 0, bytesPerPixel);
                    Marshal.Copy(pixelData, 0, newPixelPtr, bytesPerPixel);
                }
            }

            originalImage.UnlockBits(originalData);
            newImage.UnlockBits(newData);

            return newImage;
        }

        private static int CalculateBytesPerPixel(PixelFormat pixelFormat)
        {
            switch (pixelFormat)
            {
                case PixelFormat.Format24bppRgb:
                    return 3;
                case PixelFormat.Format32bppArgb:
                case PixelFormat.Format32bppRgb:
                    return 4;
                default:
                    throw new ArgumentException("Not supported.");
            }
        }
    }
}

using ImageDownsizer.Algorithms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageDownsizer.Algorithms
{
    public class NearestNeighborInterpolation
    {
        public static Bitmap NearestNeighbor(Bitmap originalImage, double scaleFactor)
        {
            int newWidth = (int)(originalImage.Width * scaleFactor);
            int newHeight = (int)(originalImage.Height * scaleFactor);

            Bitmap resized = new Bitmap(newWidth, newHeight);

            Rectangle originalRect = new Rectangle(0, 0, originalImage.Width, originalImage.Height);
            Rectangle resizedRect = new Rectangle(0, 0, newWidth, newHeight);

            BitmapData originalData = originalImage.LockBits(originalRect, ImageLockMode.ReadOnly, originalImage.PixelFormat);
            BitmapData resizedData = resized.LockBits(resizedRect, ImageLockMode.WriteOnly, originalImage.PixelFormat);

            int originalBytesPerPixel = BytesPerPixel.CalculateBytesPerPixel(originalImage.PixelFormat);

            double widthRatio = (double)originalImage.Width / newWidth;
            double heightRatio = (double)originalImage.Height / newHeight;

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int nearestX = (int)(x * widthRatio);
                    int nearestY = (int)(y * heightRatio);

                    int originalByteOffset = nearestY * originalData.Stride + nearestX * originalBytesPerPixel;
                    int resizedByteOffset = y * resizedData.Stride + x * originalBytesPerPixel;

                    for (int i = 0; i < Math.Min(originalBytesPerPixel, originalBytesPerPixel); i++)
                    {
                        byte originalPixel = Marshal.ReadByte(originalData.Scan0, originalByteOffset + i);
                        Marshal.WriteByte(resizedData.Scan0, resizedByteOffset + i, originalPixel);
                    }
                }
            }

            originalImage.UnlockBits(originalData);
            resized.UnlockBits(resizedData);

            return resized;
        }
    }
}

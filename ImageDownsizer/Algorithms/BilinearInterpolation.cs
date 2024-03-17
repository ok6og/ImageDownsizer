using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageDownsizer.Algorithms
{
    public class BilinearInterpolation
    {
        public static Bitmap BilinearInterpolationMethod(Bitmap image, double scalePercent)
        {
            int newWidth = (int)(image.Width * scalePercent);
            int newHeight = (int)(image.Height * scalePercent);

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            double xRatio = (double)(image.Width - 1) / resizedImage.Width;
            double yRatio = (double)(image.Height - 1) / resizedImage.Height;

            for (int x = 0; x < resizedImage.Width; x++)
            {
                for (int y = 0; y < resizedImage.Height; y++)
                {
                    double xScaled = x * xRatio;
                    double yScaled = y * yRatio;

                    int x0 = (int)xScaled;
                    int x1 = Math.Min(x0 + 1, image.Width - 1);
                    int y0 = (int)yScaled;
                    int y1 = Math.Min(y0 + 1, image.Height - 1);

                    double xFraction = xScaled - x0;
                    double yFraction = yScaled - y0;

                    Color c00 = image.GetPixel(x0, y0);
                    Color c01 = image.GetPixel(x0, y1);
                    Color c10 = image.GetPixel(x1, y0);
                    Color c11 = image.GetPixel(x1, y1);

                    int red = BilinearInterpolationM(c00.R, c01.R, c10.R, c11.R, xFraction, yFraction);
                    int green = BilinearInterpolationM(c00.G, c01.G, c10.G, c11.G, xFraction, yFraction);
                    int blue = BilinearInterpolationM(c00.B, c01.B, c10.B, c11.B, xFraction, yFraction);

                    resizedImage.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return resizedImage;
        }

        private static int BilinearInterpolationM(int c00, int c01, int c10, int c11, double xFraction, double yFraction)
        {
            return (int)(c00 * (1 - xFraction) * (1 - yFraction) +
                         c01 * (1 - xFraction) * yFraction +
                         c10 * xFraction * (1 - yFraction) +
                         c11 * xFraction * yFraction);
        }
    }
}

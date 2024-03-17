using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDownsizer.Algorithms
{
    public class BytesPerPixel
    {
        public static int CalculateBytesPerPixel(PixelFormat pixelFormat)
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

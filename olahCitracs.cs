using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    class olahCitracs
    {
        public static bool keBrightness(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R + 123;
                    int g1 = c1.G + 123;
                    int b1 = c1.B + 0;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }
    }
}

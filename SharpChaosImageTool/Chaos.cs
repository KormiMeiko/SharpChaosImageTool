using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpChaosImageTool
{
    public static class Chaos
    {
        private static double logistic(double u, double x, int n)
        {
            for (int i = 0; i < n; i++)
            {
                x = u * x * (1 - x);
            }
            return x;
        }
        public static Bitmap Encrypt(Bitmap src, double u, double x0)
        {
            Bitmap dest = new Bitmap(src.Width, src.Height);

            double x = logistic(u, x0, 2000);
            int key;
            for (int i = 0; i < src.Width; i++)
            {
                for (int j = 0; j < src.Height; j++)
                {
                    Color srcColor = src.GetPixel(i, j);

                    x = logistic(u, x, 5);
                    key = Convert.ToInt32(Math.Floor(x * 1000)) % 256;
                    int r = key ^ srcColor.R;
                    x = logistic(u, x, 5);
                    key = Convert.ToInt32(Math.Floor(x * 1000)) % 256;
                    int g = key ^ srcColor.G;
                    x = logistic(u, x, 5);
                    key = Convert.ToInt32(Math.Floor(x * 1000)) % 256;
                    int b = key ^ srcColor.B;

                    dest.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            return dest;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafica
{
    class CuerdaV : Vector
    {
        public double t;
        public double l;
        public double c;
        public void GraficoC(Bitmap marco, Color color0)
        {
            Vector v = new();
            double x = 0;
            do
            {
                v.x0 = x;
                Fourier(x, out v.y0);
                v.Encender(marco, color0);
                x += 0.005;
            } while (x <= l);
        }

        public double f(double x)
        {
            return ((Math.Sin(x - l)));
        }

        public double g(double x)
        {
            return 2;
        }

        public void Fourier(double x, out double sol)
        {
            double ak, bk; double sum = 0;
            int k = 1;

            do
            {
                bk = (2 / (k * Math.PI * c)) * (l / 6) * ((4 * (g(l / 2)) * Math.Sin(k * Math.PI / 2)) + (g(l) * Math.Sin(k * Math.PI)));
                ak = (2 / l) * (l / 6) * ((4 * (f(l / 2)) * Math.Sin(k * Math.PI / 2)) + (f(l) * Math.Sin(k * Math.PI))); 
                sum = sum + (ak * Math.Cos(k * Math.PI * c * t / l) + bk * (Math.Sin(k * Math.PI * c * t / l))) * Math.Sin(k * Math.PI * x / l);
                //sum = sum / 2;
                k++;
            } while (k <= 10);
            sol = sum;
        }
    }
}

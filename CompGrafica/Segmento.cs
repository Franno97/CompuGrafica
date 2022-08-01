using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafica
{
    class Segmento : Vector
    {
        public double xf, yf, X, Y;
        public override void Encender(Bitmap marco, Color color0)
        {
            Vector v = new();
            double t = 0, dt = 0.001;
            do
            {
                v.x0 = x0 * (1 - t) + xf * (t);
                v.y0 = y0 * (1 - t) + yf * (t);
               
                v.Encender(marco, color0);
                t += dt;
            } while (t <= 1);
        }
        public override void Apagar(Bitmap marco)
        {
            Vector v = new();
            double t = 0, dt = 0.001;
            do
            {
                v.x0 = x0 * (1 - t) + xf * (t);
                v.y0 = y0 * (1 - t) + yf * (t);

                v.Apagar(marco);
                t += dt;
            } while (t <= 1);
        }
    }
}

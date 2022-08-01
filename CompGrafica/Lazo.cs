using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafica
{
    class Lazo : Circunferencia
    {
        public override void Encender(Bitmap marco, Color color0)
        {
            double t = 0, dt = 0.001;

            Vector v = new();
            do
            {
                v.x0 = x0 + rad * Math.Cos(2*t);
                v.y0 = y0 + rad * Math.Sin(3*t);
                v.color0 = color0;
                v.Encender(marco, color0);
                t += dt;
            } while (t <= (3 * Math.PI));
        }
        public override void Apagar(Bitmap marco)
        {
            double t = 0, dt = 0.001;

            Vector v = new();
            do
            {
                v.x0 = x0 + rad * Math.Cos(2 * t);
                v.y0 = y0 + rad * Math.Sin(3 * t);
                v.Apagar(marco);
                t += dt;
            } while (t <= (3 * Math.PI));
        }
    }
}

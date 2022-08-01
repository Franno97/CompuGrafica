using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafica
{
    class Segmento3D : Vector3D
    {
        public double xf, yf, zf, X, Y, Z;
        public override void Encender(Bitmap marco, Color color0)
        {
            Vector3D v3D = new();
            double t = 0, dt = 0.0005;
            do
            {
                v3D.x0 = x0 * (1 - t) + xf * (t);
                v3D.y0 = y0 * (1 - t) + yf * (t);
                v3D.z0 = z0 * (1 - t) + zf * (t);
                
                v3D.Encender(marco, color0);
                t += dt;
            } while (t <= 1);
        }
        public override void Apagar(Bitmap marco)
        {
            Vector3D v3D = new();
            double t = 0, dt = 0.0005;
            do
            {
                v3D.x0 = x0 * (1 - t) + xf * (t);
                v3D.y0 = y0 * (1 - t) + yf * (t);
                v3D.z0 = z0 * (1 - t) + zf * (t);

                v3D.Apagar(marco);
                t += dt;
            } while (t <= 1);
        }
    }
}

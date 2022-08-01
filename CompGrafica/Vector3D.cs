using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafica
{
    
    class Vector3D : Vector
    {
        public double ax, ay, z0;
        public double t = 0, dt = 0.002;
        int sx, sy;
        public override void Encender(Bitmap marco, Color color0)
        {
            Proceso.Axonometria(x0, y0, z0, out ax, out ay);
            
            Proceso.Pantalla(ax, ay, out sx, out sy);

            marco.SetPixel(sx, sy, color0);
        }
        public override void Apagar(Bitmap marco)
        {
            Encender(marco, Color.Gray);
        }
    }
}

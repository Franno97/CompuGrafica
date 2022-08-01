using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafica
{
    class Vector : Proceso
    {
        public double x0;
        public double y0;
        public Color color0;

        public virtual void Encender(Bitmap marco, Color color0)
        {
            int sx, sy;
            Proceso.Pantalla(this.x0, this.y0, out sx, out sy);
            if (sx > 0 && sx < 700 && sy > 0 && sy < 450)
            {
                marco.SetPixel(sx, sy, color0);
            }
        }
        public virtual void Apagar(Bitmap marco)
        {
            
            Encender(marco, Color.Gray);
        }
    }
}

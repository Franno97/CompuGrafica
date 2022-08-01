using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafica
{
    class Onda : Vector
    {

        public double tiempo = 1;
        public double v = 9.3, m = 1, w = 1.8;
        
        public void Graf(Bitmap marco, Color[] paleta)
        {
            
            int color0;
            double x, y, z;
            Color C;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    Proceso.VReal(i, j, out x, out y);
                    z = (w * (Math.Sqrt((Math.Pow(x, 2)) + (Math.Pow(y, 2)))) - v * tiempo);
                    z = (m * (Math.Sin(z))) + 1;
                    color0 = (int)(z * 7.5);
                    C = paleta[color0];
                    marco.SetPixel(i, j, C);
                }
            }
        }
        public void Interferencia(Bitmap marco, Color[] paleta)
        {

            int color0;
            double x; double y; double z, z1, z2, z3;
            Color C;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    Proceso.VReal(i, j, out x, out y);
                    z1 = (w * (Math.Sqrt((Math.Pow(x - 5, 2)) + (Math.Pow(y, 2)))) - v * tiempo);
                    z2 = (w * (Math.Sqrt((Math.Pow(x + 5, 2)) + (Math.Pow(y, 2)))) - v * tiempo);
                    z3 = (w * (Math.Sqrt((Math.Pow(x - 4, 2)) + (Math.Pow(y + 2, 2)))) - v * tiempo);
                    z1 = (Math.Sin(z1)) + 1;
                    z2 = (Math.Sin(z2)) + 1;
                    z3 = (Math.Sin(z3)) + 1;
                    z = z1 + z2 + z3;
                    color0 = (int)(z * 2.5); //3 15/6 fuentes
                    C = paleta[color0];
                    marco.SetPixel(i, j, C);
                }
            }
        }
        public void Huyguens(Bitmap marco, Color[] paleta)
        {
            w = 2.5;
            int color0;
            double x; double y; double z, z1, z2;
            Color C;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    Proceso.VReal(i, j, out x, out y); //l=0
                    z = 0;
                    for(int l = 0; l < 13; l++)
                    {
                        z1 = (w * (Math.Sqrt((Math.Pow(x - 6 + l, 2)) + (Math.Pow(y, 2)))) - v * tiempo);
                        z = (m * (Math.Sin(z1))) + z;
                    }
                    color0 = (int)((13+z) * (15.0/26.0)); //3 15/6 fuentes
                    C = paleta[color0];
                    marco.SetPixel(i, j, C);
                }
            }
        }
        public void Graf3D(Bitmap marco, Color color0)
        {
            Vector3D v3D = new();
            double z;
            double t, dt, h, dh;

            m = 0.3;
            w = 2.5;

            t = -8; dt = 0.1;
            do
            {
                h = -5; dh = 0.1;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;
                    z = (w * (Math.Sqrt((Math.Pow(t, 2)) + (Math.Pow(h, 2)))) - (v * tiempo));
                    z = (m * (Math.Sin(z)));
                    v3D.z0 = z;
                    
                    v3D.Encender(marco, color0);
                    h += dh;
                } while (h < 5);
                t += dt;
            } while (t < 8);
        }
        public void Interf3D(Bitmap marco, Color color0)
        {
            Vector3D v3D = new();
            double z; double z1;
            double t, dt, h, dh;

            m = 0.3;
            w = 2.5;

            t = -8; dt = 0.1;
            do
            {
                h = -5; dh = 0.1;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;
                    z = (w * (Math.Sqrt((Math.Pow(t - 5, 2)) + (Math.Pow(h, 2)))) - (v * tiempo));
                    z1 = (w * (Math.Sqrt((Math.Pow(t + 5, 2)) + (Math.Pow(h, 2)))) - (v * tiempo));

                    z = (m * (Math.Sin(z)));
                    z1 = (m * (Math.Sin(z1)));

                    v3D.z0 = z + z1;

                    v3D.Encender(marco, color0);
                    h += dh;
                } while (h < 5);
                t += dt;
            } while (t < 8);
        }
        public void Huyguens3D(Bitmap marco, Color color0)
        {
            Vector3D v3D = new();
            double z; double z1;
            double t, dt, h, dh;

            m = 0.3;
            w = 2.5;

            t = -8; dt = 0.1;
            do
            {
                h = -5; dh = 0.1;
                do
                {
                    z = 0;
                    for (int l = 0; l < 13; l++)
                    {
                        v3D.x0 = t;
                        v3D.y0 = h;
                        z1 = (w * (Math.Sqrt((Math.Pow(t - 6 + l, 2)) + (Math.Pow(h, 2)))) - (v * tiempo));
                        z = (m * (Math.Sin(z1))) + z;
                        v3D.z0 = z;
                    }

                    v3D.Encender(marco, color0);
                    h += dh;
                } while (h < 5);
                t += dt;
            } while (t < 8);
        }
    }
}

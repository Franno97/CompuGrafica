using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafica
{
    class Proceso
    {
        static int sx1 = 0;
        public static int sx2 = 700;
        static int sy1 = 0;
        public static int sy2 = 420;
        public static double x1 = -10;  //10
        public static double x2 = 10;
        public static double y1 = -5.98; //5.98
        public static double y2 = 5.98;

        public static void Pantalla(double x0, double y0, out int sx, out int sy)
        {
            sx = (int)((((x0 - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1);
            sy = (int)((((y0 - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1);
        }

        //public static void VReal(int sx, int sy, out double x0, out double y0)
        //{
        //    x0 = ((sx2)*(sx - x1) + (sx1) * (x2 - x1))/(x2 - x1);
        //    y0 = ((((sy - sy2)*(y2 - y1))/(sy1 - sy2)) + y1);
        //}

        public static void VReal(int px, int py, out double x, out double y)
        {
            x = (((px - sx2) * (x2 - x1)) / (sx2 - sx1)) + x2;
            y = (((py - sy1) * (y1 - y2)) / (sy2 - sy1)) + y2;
        }

        public static void Axonometria(double x0, double y0, double z0, out double ax, out double ay)
        {
            ax = y0 - ((x0 / 2) * (Math.Cos(Math.PI / 4)));
            ay = z0 - ((x0 / 2) * (Math.Sin(Math.PI / 4)));
        }
    }
}

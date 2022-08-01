namespace CompGrafica
{
    public partial class Form1 : Form
    {
        public Bitmap marco = new Bitmap(700, 420);
        
        private void btnEjes_Click(object sender, EventArgs e)
        {
            Segmento x = new Segmento();
            Segmento y = new Segmento();

            x.x0 = -10;
            x.y0 = 0;
            x.xf = 10;
            x.yf = 0;
            
            x.Encender(marco, Color.Black);
            pantalla.Image = marco;
            
            y.x0 = 0;
            y.y0 = -5.97;
            y.xf = 0;
            y.yf = 5.97;
           
            y.Encender(marco, Color.Black);
            pantalla.Image = marco;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            //Sitio de pruebas
            Onda o = new();
            double tp = 0;
            double dtp = 0.01;
            do
            {
                o.tiempo = tp;
                o.Huyguens3D(marco, Color.Aqua);
                pantalla.Refresh();
                pantalla.Image = marco;
                o.Huyguens3D(marco, Color.Gray);
                pantalla.Image = marco;
                tp += dtp;
            } while (tp < 4);
            //Vector v = new();
            //double t = -7;

            //do
            //{
            //    v.x0 = t;
            //    v.y0 = 1.2 * t + 5.4;
            //    v.Encender(marco, Color.Red);

            //    pantalla.Image = marco;
            //    t += 0.001;
            //} while (t <= -2);

            //t = -2;

            //do
            //{
            //    v.x0 = t;
            //    v.y0 = ((-(t * t) + (2 * t) + 8) / 4.5) + 3;
            //    v.Encender(marco, Color.Red);

            //    pantalla.Image = marco;
            //    t += 0.001;
            //} while (t <= 4);

            //Circunferencia c = new();


            //t = -7;
            //c.rad = 0.6;
            //do
            //{
            //    c.x0 = t;
            //    c.y0 = 1.2*t +5.4;
            //    c.Encender(marco, Color.Aqua);
            //    pantalla.Image = marco;
            //    pantalla.Refresh();
            //    Thread.Sleep(50);
            //    c.Apagar(marco);
            //    pantalla.Image = marco;
            //    t += 0.2;
            //} while (t <= -2);

            //t = -2;
            //c.rad = 0.6;
            //do
            //{
            //    c.x0 = t;
            //    c.y0 = ((-(t * t) + (2 * t) + 8) / 4.5) + 3;
            //    c.Encender(marco, Color.Aqua);
            //    pantalla.Image = marco;
            //    pantalla.Refresh();
            //    Thread.Sleep(50);
            //    c.Apagar(marco);
            //    pantalla.Image = marco;
            //    t += 0.2;
            //} while (t <= 4);


        }
        public Form1()
        {
            InitializeComponent();
            pantalla.BackColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Segmento3D s3d = new Segmento3D();
            s3d.x0 = 0;
            s3d.y0 = 0;
            s3d.z0 = 0;

            s3d.xf= 0;
            s3d.yf = 0;
            s3d.zf = 5;
            s3d.color0 = Color.Black;
            s3d.Encender(marco, Color.Black);
            pantalla.Image = marco;

            s3d.yf = 5;
            s3d.zf = 0;
            s3d.Encender(marco, Color.Black);
            pantalla.Image = marco;

            s3d.xf = 8;
            s3d.yf = 0;
            s3d.Encender(marco, Color.Black);
            pantalla.Image = marco;
            //8
            s3d.z0 = 5;
            s3d.yf = 0;
            s3d.zf = 5;
            s3d.Encender(marco, Color.Black);
            pantalla.Image = marco;
            //9
            s3d.x0 = 8;
            s3d.y0 = 0;
            s3d.z0 = 0;
            s3d.Encender(marco, Color.Black);
            pantalla.Image = marco;
            //4
            s3d.xf = 8;
            s3d.yf = 5;
            s3d.zf = 0;
            s3d.Encender(marco, Color.Black);
            pantalla.Image = marco;
            //5
            s3d.x0 = 0;
            s3d.y0 = 5;
            s3d.z0 = 0;
            s3d.Encender(marco, Color.Black);
            pantalla.Image = marco;
            //6
            s3d.xf = 0;
            s3d.yf = 5;
            s3d.zf = 5;
            s3d.Encender(marco, Color.Black);
            pantalla.Image = marco;
            //7
            s3d.x0 = 0;
            s3d.y0 = 0;
            s3d.z0 = 5;
            s3d.Encender(marco, Color.Black);
            pantalla.Image = marco;

        }

        private void btnBandera_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {

                    //marco.SetPixel(i, j, Color.FromArgb(255, 0, (255 * i / 700), (-255 / 700) * (i - 700))); //verde al azul

                    //marco.SetPixel(i, j, Color.FromArgb(255, 255, (int)(((-255 * i) / 700) + 255), 0)); //amarillo a rojo

                    //marco.SetPixel(i, j, Color.FromArgb(255, 255, (int)((255*((i-350)*(i-700))/245000)+(255*((i)*(i-700))/(-122500))), (int)(255*i*(i-700))/(-122500))); //amarillo a rojo

                    if (i < 350)
                    {
                        marco.SetPixel(i, j, Color.FromArgb(255, 255, 255, (int)(255 * i / 350)));
                        pantalla.Image = marco;
                    }
                    else
                    {
                        marco.SetPixel(i, j, Color.FromArgb(255, 255, (int)(-255 * i / 350 + 510), (int)(255 * (i - 700) / -350)));
                        pantalla.Image = marco;
                    }

                    pantalla.Image = marco;
                    
                }
            }
        }

        private void btnSegmento_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento();

            s.x0 = -5;
            s.y0 = 4.5;
            s.xf = 6;
            s.yf = 1.5;
            
            s.Encender(marco, Color.Aqua);
            pantalla.Image = marco;

            Segmento s1 = new Segmento();

            s1.x0 = 6;
            s1.y0 = 1.5;
            s1.xf = -5;
            s1.yf = -4.5;
            
            s1.Encender(marco, Color.Aqua);
            pantalla.Image = marco;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Segmento3D s = new();
            s.x0 = -5;
            s.y0 = 4.5;
            s.xf = 6;
            s.yf = 1.5;
            s.z0 = 3;
            s.zf = 2;

            s.Encender(marco, Color.Aqua);
            pantalla.Image = marco;
        }

        private void btnCircun_Click(object sender, EventArgs e)
        {
            Circunferencia c = new()
            {
                x0 = 6,
                y0 = 1.5,
                rad = 1,
            };
            c.Encender(marco, Color.Aqua);
            pantalla.Image = marco;
        }

        private void btnLazo_Click(object sender, EventArgs e)
        {
            Lazo l = new()
            {
                x0 = -4,
                y0 = 2,
                rad = 1,
            };
            l.Encender(marco, Color.Aqua);
            pantalla.Image = marco;

        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            Raiz r = new()
            {
                x0 = 2,
                y0 = 4,
                rad = 1.5,
            };
            r.Encender(marco, Color.Aqua);
            pantalla.Image = marco;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            double h = 0;
            Vector3D v3D = new();
            do
            {
                v3D.x0 = 5 + (1 * Math.Cos(h)); // tamaño y radio
                v3D.y0 = 4 + (1 * Math.Sin(h));
                v3D.z0 = 0 + (h / 10);  //aplastadp o estirado
                v3D.Encender(marco, Color.Aqua);
                pantalla.Image = marco;
                h += 0.002;
            } while (h <= 20); //cuantas vueltas da
        }

        private void btnParaboloide_Click(object sender, EventArgs e)
        {
            double t = -5;
            Vector3D v3D = new();
            do
            {
                double h = -4;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;
                    v3D.z0 = 0.15 * ((t * t) + (h * h)) - 3;  //paraboloide (con signo negativo paraboloide hiperbolico))
                    v3D.Encender(marco, Color.Aqua);

                    pantalla.Image = marco;
                    h += 0.1;
                } while (h <= 4);
                t += 0.1;
            } while (t <= 5);
        }

        private void btnTiro_Click(object sender, EventArgs e)
        {
            double t = -3;
            Vector v = new();
            do
            {
                v.x0 = t;
                v.y0 = ((-(t * t) + (5 * t) + 24) / 6.2);
                v.Encender(marco, Color.Red);

                pantalla.Image = marco;
                t += 0.001;
            } while (t <= 8);
            Circunferencia c = new();
            t = -3;
            c.rad = 0.3;
            do
            {
                c.x0 = t;
                c.y0 = ((-(t * t) + (5 * t) + 24) / 6.2);
                c.color0 = Color.Black;
                c.Encender(marco, Color.Aqua);
                pantalla.Image = marco;
                pantalla.Refresh();
                Thread.Sleep(50);
                c.Apagar(marco);
                pantalla.Image = marco;
                t += 0.2;
            } while (t <= 8);
        }

        private void btnRebote_Click(object sender, EventArgs e)
        {
            double t = -8;
            Vector v = new();
            do
            {
                v.x0 = t;
                v.y0 = ((-(t * t) - (8 * t)) / 4);
                v.Encender(marco, Color.Red);

                pantalla.Image = marco;
                t += 0.001;
            } while (t <= 0);
            t = 0;
            do
            {
                v.x0 = t;
                v.y0 = ((-(t * t) + (4 * t)) / 2);
                v.Encender(marco, Color.Red);
                pantalla.Image = marco;
                t += 0.001;
            } while (t <= 4);
            t = 4;
            do
            {
                v.x0 = t;
                v.y0 = ((-(t * t) + (10 * t) - 24));
                v.Encender(marco, Color.Red);
                pantalla.Image = marco;
                t += 0.001;
            } while (t <= 6);
            t = 6;
            do
            {
                v.x0 = t;
                v.y0 = ((-(t * t * 2) + (26 * t) - 84));
                v.Encender(marco, Color.Red);
                pantalla.Image = marco;
                t += 0.001;
            } while (t <= 7);

            Circunferencia c = new();
            t = -8;
            c.rad = 0.3;
            do
            {
                c.x0 = t;
                c.y0 = ((-(t * t) - (8 * t)) / 4);
                c.Encender(marco, Color.Black);
                pantalla.Image = marco;
                pantalla.Refresh();
                Thread.Sleep(50);
                c.Apagar(marco);
                pantalla.Image = marco;
                t += 0.2;
            } while (t <= 0);
            t = 0;
            c.rad = 0.3;
            do
            {
                c.x0 = t;
                c.y0 = ((-(t * t) + (4 * t)) / 2);
                c.color0 = Color.Black;

                c.Encender(marco, Color.Black);
                pantalla.Image = marco;
                pantalla.Refresh();
                Thread.Sleep(50);
                c.Apagar(marco);
                pantalla.Image = marco;
                t += 0.2;
            } while (t <= 4);
            t = 4;
            c.rad = 0.3;
            do
            {
                c.x0 = t;
                c.y0 = ((-(t * t) + (10 * t) - 24));
                c.color0 = Color.Black;
                c.Encender(marco, Color.Black);
                pantalla.Image = marco;
                pantalla.Refresh();
                Thread.Sleep(50);
                c.Apagar(marco);
                pantalla.Image = marco;
                t += 0.2;
            } while (t <= 6);
            t = 6;
            c.rad = 0.3;
            do
            {
                c.x0 = t;
                c.y0 = ((-(t * t * 2) + (26 * t) - 84));
                c.color0 = Color.Black;

                c.Encender(marco, Color.Black);
                pantalla.Image = marco;
                pantalla.Refresh();
                Thread.Sleep(50);
                c.Apagar(marco);
                pantalla.Image = marco;
                t += 0.2;
            } while (t <= 7);
        }

        private void btnBolayPista_Click(object sender, EventArgs e)
        {
            //marcos
            Circunferencia c1 = new()
            {
                x0 = 0,
                y0 = 0,
                rad = 2,
            };
            c1.Encender(marco, Color.Black);
            pantalla.Image = marco;

            Circunferencia c2 = new()
            {
                x0 = 0,
                y0 = 0,
                rad = 4,
            };
            c2.Encender(marco, Color.Black);
            pantalla.Image = marco;

            //circulo que se mueve
            Circunferencia c = new();
            double t = -3;
            c.rad = 0.3;
            do
            {
                c.x0 = t;
                c.y0 = (((t * t) - 9) / 2.9);
                c.Encender(marco, Color.Aqua);
                pantalla.Image = marco;
                pantalla.Refresh();
                Thread.Sleep(50);
                c.Apagar(marco);
                pantalla.Image = marco;
                t += 0.2;
            } while (t <= 3);

            t = 3;
            do
            {
                c.x0 = t;
                c.y0 = (-1) * (((t * t) - 9) / 2.9);
                c.Encender(marco, Color.Aqua);
                pantalla.Image = marco;
                pantalla.Refresh();
                Thread.Sleep(50);
                c.Apagar(marco);
                pantalla.Image = marco;
                t -= 0.2;
            } while (t >= -3);
        }

        private void btnChoqueCurvas_Click(object sender, EventArgs e)
        {
            double t = -2.99;
            Vector v = new();
            do
            {
                v.x0 = t;
                v.y0 = (1 / (t + 3));
                v.Encender(marco, Color.Blue);
                pantalla.Image = marco;

                v.y0 = ((Math.Pow(t, 2) / 27) - (t / 9) + 0.33);
                v.Encender(marco, Color.Red);
                pantalla.Image = marco;

                t += 0.001;
            } while (t <= 10);
        }
        public Color[] paleta1 = new Color[16];
        public Color[] paleta2 = new Color[16];
        public Color[] paleta3 = new Color[16];
        public Color[] paleta4 = new Color[16];
        public Color[] paleta5 = new Color[16];
        public void Paletas()
        {
            //PALETA 1
            paleta1[0] = Color.Black; paleta1[1] = Color.Navy; paleta1[2] = Color.Green; paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red; paleta1[5] = Color.Purple; paleta1[6] = Color.Maroon; paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray; paleta1[9] = Color.Blue; paleta1[10] = Color.Lime; paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal; paleta1[13] = Color.Fuchsia; paleta1[14] = Color.Yellow; paleta1[15] = Color.White;
            //PALETA 2
            paleta2[0] = Color.White; paleta2[1] = Color.Green; paleta2[2] = Color.Red; paleta2[3] = Color.Blue;
            paleta2[4] = Color.Red; paleta2[5] = Color.Green; paleta2[6] = Color.Gold; paleta2[7] = Color.Magenta;
            paleta2[8] = Color.Yellow; paleta2[9] = Color.SaddleBrown; paleta2[10] = Color.Aquamarine; paleta2[11] = Color.Black;
            paleta2[12] = Color.BlueViolet; paleta2[13] = Color.Azure; paleta2[14] = Color.Orange; paleta2[15] = Color.Orchid;
            //PALETA 3
            for (int k = 0; k <= 15; k++)
            {
                paleta3[k] = Color.FromArgb(255, 0, (int)((15.67 * k) + 19.95), (int)((15 * k) + 30));
            }
            //PALETA APAGAR
            for(int k = 0; k <= 15; k++)
            {
                paleta4[k] = Color.Gray;
            }

            //paleta5
            for (int k = 0; k <= 15; k++)
            {
                paleta5[k] = Color.FromArgb(255, (int)((255*k)/15), (int)((255 * k) / 15), (int)((-255 / 15)*(k - 15)));
            }
        }
        private void btnOnda_Click(object sender, EventArgs e)
        {
            Paletas();
            Onda o = new();
            o.Graf(marco, paleta5);
            pantalla.Image = marco;
        }

        private void btnInterferenciaO_Click(object sender, EventArgs e)
        {
            Paletas();
            Onda o = new();
            o.Interferencia(marco, paleta3);
            pantalla.Image = marco;
        }

        private void btnOnda3D_Click(object sender, EventArgs e)
        {
            
            Onda o = new();
            o.Graf3D(marco, Color.Aqua);
            pantalla.Image = marco;
        }

        private void btnAnimOnda_Click(object sender, EventArgs e)
        {
            Paletas();
            Onda o = new();
            double tp = 0;
            double dtp = 0.09;
            do
            {
                o.tiempo = tp;
                o.Graf(marco, paleta3);
                pantalla.Refresh();
                pantalla.Image = marco;
                tp += dtp;
            } while (tp < 4);
            //o.Graf(marco, paleta4);
            pantalla.Image = marco;
        }

        private void btnAnimInterf_Click(object sender, EventArgs e)
        {
            Paletas();
            Onda o = new();
            double tp = 0;
            double dtp = 0.09;
            do
            {
                o.tiempo = tp;
                o.Interferencia(marco, paleta1);
                pantalla.Refresh();
                pantalla.Image = marco;
                tp += dtp;
            } while (tp < 4);
            o.Interferencia(marco, paleta4);
            pantalla.Image = marco;
        }

        private void btnAnimOnd3d_Click(object sender, EventArgs e)
        {
            Onda o = new();
            double tp = 0;
            double dtp = 0.01;
            do
            {
                o.tiempo = tp;
                o.Graf3D(marco, Color.Aqua);
                pantalla.Refresh();
                pantalla.Image = marco;
                o.Graf3D(marco, Color.Gray);
                pantalla.Image = marco;
                tp += dtp;
            } while (tp < 4);
        }

        private void btnInterfOnd3D_Click(object sender, EventArgs e)
        {
            Onda o = new();
            o.Interf3D(marco, Color.Aqua);
            pantalla.Image = marco;
        }

        private void btnAnimInter3D_Click(object sender, EventArgs e)
        {
            Onda o = new();
            double tp = 0;
            double dtp = 0.01;
            do
            {
                o.tiempo = tp;
                o.Interf3D(marco, Color.Aqua);
                pantalla.Refresh();
                pantalla.Image = marco;
                o.Interf3D(marco, Color.Gray);
                pantalla.Image = marco;
                tp += dtp;
            } while (tp < 4);
        }

        private void btnHuyguens_Click(object sender, EventArgs e)
        {
            Paletas();
            Onda o = new();
            o.Huyguens(marco, paleta3);
            pantalla.Image = marco;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Paletas();
            Onda o = new();
            double tp = 0;
            double dtp = 0.2;
            do
            {
                o.tiempo = tp;
                o.Huyguens(marco, paleta3);
                pantalla.Refresh();
                pantalla.Image = marco;
                tp += dtp;
            } while (tp < 4);
            o.Huyguens(marco, paleta4);
            pantalla.Image = marco;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Onda o = new();
            o.Huyguens3D(marco, Color.Aqua);
            pantalla.Image = marco;
        }

        private void btnCuerdaV_Click(object sender, EventArgs e)
        {
            CuerdaV c = new()
            {
                c = 1,
                l = 6,
                t = 2
            };
            c.GraficoC(marco, Color.Aqua);
            pantalla.Image = marco;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CuerdaV c = new()
            {
                c = 1,
                l = 6,
                t = 0
            };
            double tp = 0;
            double dtp = 0.0009;
            do
            {
                c.t = tp;
                c.GraficoC(marco, Color.Aqua);
                pantalla.Image = marco;
                pantalla.Refresh();
                
                c.GraficoC(marco, Color.Gray);
                pantalla.Image = marco;
                
                tp += dtp;
            } while (tp < 4);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    marco.SetPixel(i, j, pantalla.BackColor);
                    pantalla.Image = marco;
                }
            }
        }
    }
}
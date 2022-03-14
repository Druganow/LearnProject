using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        Graphics Graph;
        Pen MyPen;
        Font font = new Font("Arial", 10);
        Brush brush = Brushes.Red;
        const double xMin = -20;
        const double xMax = 5;
        int N;
        double step;
        double k = 20;
        int x0;
        int y0;
        public Form1()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyPen = new Pen(Color.Black, 2);
           
            x0 = this.ClientSize.Width / 2;
            y0 = this.ClientSize.Height / 2;
            
        }

            private void button1_Click(object sender, EventArgs e)
        {
            k = 20;
            Graph.Clear(Color.White);
            N = int.Parse(textBox1.Text);
            switch(comboBox1.Text)
            {
                case "1": ris1(N); break;
                case "2": ris2(N); break;
                case "3.a": ris3(0); break;
                case "3.b": ris3(1); break;
                case "3.c": ris3(2); break;
                case "3.d": ris3(3); break;
                case "4": ris4(N); break;
                case "5": ris5(N); break;

            }
            
            

        }

        private void ris5(int n)
        {
            x0 = this.ClientSize.Width / 2;
            y0 = this.ClientSize.Height / 2;
            N = 3;
            k = 60;
            step = Math.PI /N*2;
            int x1, y1, x2, y2;
            double x, y;
            int R = 4, r = 2;
            //фактические координаты в начальной точке заданного диапазона
            for (int h = 0; h <n; h++)
            {
                x = R *  Math.Cos(h *Math.PI / n*2/3);
                y = R * Math.Sin(h * Math.PI / n*2/3);
                //соответствующие им экранные координаты
                x1 = (int)(x0 + x * k);
                y1 = (int)(y0 - y * k);
                for (int i = 0; i <= N; i++)
                //определение фактических координат графика в следующей точке
                {

                    x = R * Math.Cos(i*step+Math.PI*h/n*2/3);
                    y = R * Math.Sin(i * step + Math.PI * h / n * 2/3);
                    //соответствующие им экранные координаты
                    x2 = (int)(x0 + x * k);
                    y2 = (int)(y0 - y * k);
                    //вывод отрезка графика на экран
                    Graph.DrawLine(MyPen, x1, y1, x2, y2);
                    //запоминаем текущие координаты
                    x1 = x2;
                    y1 = y2;
                }
            }


            //соответствующие им экранные координаты


        }

        private void ris4(int N)
        {
            x0 = this.ClientSize.Width / 2;
            y0 = this.ClientSize.Height / 2;
            k = 60;
            step = 2 * Math.PI / N / 2;
            int x1, y1, x2, y2;
            double x, y;
            int R = 4, r = 2;
            //фактические координаты в начальной точке заданного диапазона
            x = R;
            y = 0;

            //соответствующие им экранные координаты
            x1 = (int)(x0 + x * k);
            y1 = (int)(y0 - y * k);
            for (int i = 0; i <= 2 * N; i++)
            //определение фактических координат графика в следующей точке
            {

                x = R * Math.Cos(i * step);
                y = R * Math.Sin(i * step);


                //соответствующие им экранные координаты
                x2 = (int)(x0 + x * k);
                y2 = (int)(y0 - y * k);
                //вывод отрезка графика на экран
                Graph.DrawLine(MyPen, x1, y1, x2, y2);
                //запоминаем текущие координаты
                x1 = x2;
                y1 = y2;
            }
            x = R * Math.Cos(Math.PI / N / 2);
            y = R * Math.Sin(Math.PI / N / 2);
            //соответствующие им экранные координаты
            x1 = (int)(x0 + x * k);
            y1 = (int)(y0 - y * k);
            for (int i = 0; i <= 2 * N; i++)
            //определение фактических координат графика в следующей точке
            {

                x = R * Math.Cos(i * step+Math.PI / N/2) ;
                y = R * Math.Sin(i * step+Math.PI / N/2);


            //соответствующие им экранные координаты
            x2 = (int)(x0 + x * k);
                y2 = (int)(y0 - y * k);
                //вывод отрезка графика на экран
                Graph.DrawLine(MyPen, x1, y1, x2, y2);
                //запоминаем текущие координаты
                x1 = x2;
                y1 = y2;
            }
        }

        private void ris3(int N)
        {
            switch(N)
            {
                case 0: ornam0();break;
                case 1: ornam1(); break;
                case 2: ornam2(); break;
                case 3: ornam3(); break;
            }
        }

        private void ornam3()
        {
            N = 6;
            step = 2 * Math.PI / N / 2;
            int x1, y1, x2, y2;
            double x, y;
            int R = 2, r = 1;
            x0 = y0 = 20;
            for (; x0 < this.ClientSize.Width; x0 += 60)
            {
                if ((x0 - 20) % 120 == 0) y0 = 35;
                else y0 = 70;
                for (; y0 < this.ClientSize.Height; y0 += 70)
                {
                    //фактические координаты в начальной точке заданного диапазона
                    x = R;
                    y = 0;

                    //соответствующие им экранные координаты
                    x1 = (int)(x0 + x * k);
                    y1 = (int)(y0 - y * k);
                    for (int i = 0; i <= 2 * N; i++)
                    //определение фактических координат графика в следующей точке
                    {
                        if (i % 2 == 1)
                        {
                            x = r * Math.Cos(i * step);
                            y = r * Math.Sin(i * step);
                        }
                        else
                        {
                            x = R * Math.Cos(i * step);
                            y = R * Math.Sin(i * step);
                        }

                        //соответствующие им экранные координаты
                        x2 = (int)(x0 + x * k);
                        y2 = (int)(y0 - y * k);
                        //вывод отрезка графика на экран
                        Graph.DrawLine(MyPen, x1, y1, x2, y2);
                        //запоминаем текущие координаты
                        x1 = x2;
                        y1 = y2;
                    }
                }
            }
        }

        private void ornam2()
        {
            N = 3;
            step = 2 * Math.PI / N / 2;
            int x1, y1, x2, y2;
            double x, y;
            int R = 2, r = 2;
            x0 = y0 = 20;
            for (; x0 < this.ClientSize.Width; x0 += 60)
            {
                if ((x0 - 20) % 120 == 0) y0 = 35;
                else y0 = 70;
                for (; y0 < this.ClientSize.Height; y0 += 70)
                {
                    //фактические координаты в начальной точке заданного диапазона
                    x = r;
                    y = 0;

                    //соответствующие им экранные координаты
                    x1 = (int)(x0 + x * k);
                    y1 = (int)(y0 - y * k);
                    for (int i = 0; i <= 2 * N; i++)
                    //определение фактических координат графика в следующей точке
                    {
                        if (i % 2 == 0)
                        {
                            x = r * Math.Cos(i * step);
                            y = r * Math.Sin(i * step);
                        }
                        else
                        {
                            x = R * Math.Cos(i * step);
                            y = R * Math.Sin(i * step);
                        }

                        //соответствующие им экранные координаты
                        x2 = (int)(x0 + x * k);
                        y2 = (int)(y0 - y * k);
                        //вывод отрезка графика на экран
                        Graph.DrawLine(MyPen, x1, y1, x2, y2);
                        //запоминаем текущие координаты
                        x1 = x2;
                        y1 = y2;
                    }
                }
            }
                
        }

        private void ornam1()
        {
            N = 4;
            step = 2 * Math.PI / N / 2;
            int x1, y1, x2, y2;
            double x, y;
            int R = 2, r = 1;
            x0 = y0 = 50;
            for (x0 = 40; x0 < this.ClientSize.Width; x0 += 80)
                for (y0 = 40; y0 < this.ClientSize.Height; y0 += 80)
                {
                    
                    //фактические координаты в начальной точке заданного диапазона
                    x = R;
                    y = 0;

                    //соответствующие им экранные координаты
                    x1 = (int)(x0 + x * k);
                    y1 = (int)(y0 - y * k);
                    for (int i = 0; i <= 2 * N; i++)
                    //определение фактических координат графика в следующей точке
                    {
                        
                        //запоминаем текущие координаты
                        {

                            x = R * Math.Cos(i * step);
                            y = R * Math.Sin(i * step);
                            x2 = (int)(x0 + x * k);
                            y2 = (int)(y0 - y * k);
                            //вывод отрезка графика на экран
                            Graph.DrawLine(MyPen, x1, y1, x2, y2);
                            //запоминаем текущие координаты
                            x1 = x2;
                            y1 = y2;
                        }
                    }
                    for (int i = 0; i <= 2 * N; i++)
                    {
                        if (i % 2 == 1)
                        {
                            x = r * Math.Cos(i * step);
                            y = r * Math.Sin(i * step);
                        }
                        else
                        {
                            x = R * Math.Cos(i * step);
                            y = R * Math.Sin(i * step);
                        }

                        //соответствующие им экранные координаты
                        x2 = (int)(x0 + x * k);
                        y2 = (int)(y0 - y * k);
                        //вывод отрезка графика на экран
                        Graph.DrawLine(MyPen, x1, y1, x2, y2);
                        x1 = x2;
                        y1 = y2;
                    }

                }


        }

        private void ornam0()
        {
            N = 4;
            step = 2 * Math.PI / N / 2;
            int x1, y1, x2, y2;
            double x, y;
            int R = 2, r = 2;
            x0 =y0= 50;
            for (x0 = 40; x0 < this.ClientSize.Width; x0 += 80)
                for (y0=40; y0 < this.ClientSize.Height; y0 += 80)
                {
                    //фактические координаты в начальной точке заданного диапазона
                    x = r;
                    y = 0;

                    //соответствующие им экранные координаты
                    x1 = (int)(x0 + x * k);
                    y1 = (int)(y0 - y * k);
                    for (int i = 0; i <= 2 * N; i++)
                    //определение фактических координат графика в следующей точке
                    {
                        if (i % 2 == 0)
                        {
                            x = r * Math.Cos(i * step);
                            y = r * Math.Sin(i * step);
                        }
                        else
                        {
                            x = R * Math.Cos(i * step);
                            y = R * Math.Sin(i * step);
                        }

                        //соответствующие им экранные координаты
                        x2 = (int)(x0 + x * k);
                        y2 = (int)(y0 - y * k);
                        //вывод отрезка графика на экран
                        Graph.DrawLine(MyPen, x1, y1, x2, y2);
                        //запоминаем текущие координаты
                        x1 = x2;
                        y1 = y2;
                    }
                }
            
             
        }

        private void ris2(int N)
        {
            y0 = this.ClientSize.Height / 2;
            step = 2 * Math.PI / N / 2;
            int x1, y1, x2, y2;
            double x, y;
            int R = 4, r = 2;
            x0 = this.ClientSize.Width / 3;
            //фактические координаты в начальной точке заданного диапазона
            x = r;
            y = 0;

            //соответствующие им экранные координаты
            x1 = (int)(x0 + x * 1.5 * k);
            y1 = (int)(y0 - y * k);
            for (int i = 0; i <= 2 * N; i++)
            //определение фактических координат графика в следующей точке
            {
                if (i % 2 == 0)
                {
                    x = r * Math.Cos(i * step);
                    y = r * Math.Sin(i * step);
                }
                else
                {
                    x = R * Math.Cos(i * step);
                    y = R * Math.Sin(i * step);
                }

                //соответствующие им экранные координаты
                x2 = (int)(x0 + x * 1.5* k);
                y2 = (int)(y0 - y  * k);
                //вывод отрезка графика на экран
                Graph.DrawLine(MyPen, x1, y1, x2, y2);
                //запоминаем текущие координаты
                x1 = x2;
                y1 = y2;
            }

            x0 = 2*this.ClientSize.Width / 3;
            step = 2 * Math.PI / N ;
            r =R;
            //фактические координаты в начальной точке заданного диапазона
            x = r;
            y = 0;

            //соответствующие им экранные координаты
            x1 = (int)(x0 + x * 1.5 * k);
            y1 = (int)(y0 - y * k);
            for (int i = 0; i <= N ; i++)
            //определение фактических координат графика в следующей точке
            {
                if (i % 2 == 0)
                {
                    x = r * Math.Cos(i * step);
                    y = r * Math.Sin(i * step);
                }
                else
                {
                    x = R * Math.Cos(i * step);
                    y = R * Math.Sin(i * step);
                }

                //соответствующие им экранные координаты
                x2 = (int)(x0 + x * 1.5 * k);
                y2 = (int)(y0 - y * k);
                //вывод отрезка графика на экран
                Graph.DrawLine(MyPen, x1, y1, x2, y2);
                //запоминаем текущие координаты
                x1 = x2;
                y1 = y2;
            }
        }

        private void ris1(int N)
        {
            y0 = this.ClientSize.Height / 2;
            step = 2 * Math.PI / N / 2;
            int x1, y1, x2, y2;
            double x, y;
            int R = 4, r = 2;
            x0 = this.ClientSize.Width / 4;
            //фактические координаты в начальной точке заданного диапазона
            x = r;
            y = 0;

            //соответствующие им экранные координаты
            x1 = (int)(x0 + x * k);
            y1 = (int)(y0 - y * k);
            for (int i = 0; i <= 2 * N; i++)
            //определение фактических координат графика в следующей точке
            {
                if (i % 2 == 0)
                {
                    x = r * Math.Cos(i * step);
                    y = r * Math.Sin(i * step);
                }
                else
                {
                    x = R * Math.Cos(i * step);
                    y = R * Math.Sin(i * step);
                }

                //соответствующие им экранные координаты
                x2 = (int)(x0 + x * k);
                y2 = (int)(y0 - y *k);
                //вывод отрезка графика на экран
                Graph.DrawLine(MyPen, x1, y1, x2, y2);
                Graph.DrawLine(MyPen, x0, y0, x2, y2);
                //запоминаем текущие координаты
                x1 = x2;
                y1 = y2;
            }

            x0 = 2*this.ClientSize.Width / 4;
            //фактические координаты в начальной точке заданного диапазона
            x = R;
            y = 0;

            //соответствующие им экранные координаты
            x1 = (int)(x0 + x * k);
            y1 = (int)(y0 - y * k);
            for (int i = 0; i <= 2 * N; i++)
            //определение фактических координат графика в следующей точке
            {
                
                    x = R * Math.Cos(i * step);
                    y = R * Math.Sin(i * step);
              

                //соответствующие им экранные координаты
                x2 = (int)(x0 + x * k);
                y2 = (int)(y0 - y *k);
                //вывод отрезка графика на экран
                Graph.DrawLine(MyPen, x1, y1, x2, y2);
                Graph.DrawLine(MyPen, x0, y0, x2, y2);
                //запоминаем текущие координаты
                x1 = x2;
                y1 = y2;
            }

            x0 = 3 * this.ClientSize.Width / 4;
            //фактические координаты в начальной точке заданного диапазона
            x = R;
            y = 0;
            int x3 = (int)(x0 + x * k);
            int y3 = (int)(y0 - y * k);
            //соответствующие им экранные координаты
            x1 = (int)(x0 + x * k);
            y1 = (int)(y0 - y * k);
            for (int i = 0; i <= 2 * N; i++)
            //определение фактических координат графика в следующей точке
            {
                if (i % 2 == 1)
                {
                    x = r * Math.Cos(i * step);
                    y = r * Math.Sin(i * step);

                }
                else
                {
                    x = R * Math.Cos(i * step);
                    y = R * Math.Sin(i * step);

                }

                //соответствующие им экранные координаты
                x2 = (int)(x0 + x * k);
                y2 = (int)(y0 - y * k);
                //вывод отрезка графика на экран
                Graph.DrawLine(MyPen, x1, y1, x2, y2);
                if (i % 2 == 0)
                {
                    Graph.DrawLine(MyPen, x3, y3, x2, y2);
                    x3 = (int)(x0 + x * k);
                    y3 = (int)(y0 - y * k);
                }

                //запоминаем текущие координаты
                x1 = x2;
                y1 = y2;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

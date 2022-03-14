using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        const double step = 0.005;
        double k = 50;
        int x0;
        int y0;
        public Form1()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyPen = new Pen(Color.Black);
            x0 = this.ClientSize.Width / 2;
            y0 = this.ClientSize.Height / 2;
        }

        private void Grafic()
        {
            Graph.DrawLine(MyPen, 0, y0,2 * x0, y0);
            Graph.DrawLine(MyPen, x0, 0, x0, 2 * x0);
            for (int i = -6; i < 7; i++)
            {
                Graph.DrawLine(MyPen, x0 - 10, y0 + i * (float)k, x0 + 10, y0 + i * (float)k);
                Graph.DrawString((-1 * i).ToString(), font, brush, (float)x0, y0 + i * (float)k);
            }
            for (double i = -6; i < 2; i++)
            {
                Graph.DrawLine(MyPen, (float)(x0 + 3.14 * i * k), y0 - 10, (float)(x0 + 3.14 * i * k), y0 + 10);
                Graph.DrawString(i.ToString() + "п", font, brush, (float)(x0 + 3.14 * i * k), (float)y0);
            }
            Graph.DrawString("X", font, brush, (float)1.4 * x0, y0 + 10);
            Graph.DrawString("Y", font, brush, x0 + 10, 10);
            Graph.DrawLine(MyPen, x0, 0, x0 - 10, 10);
            Graph.DrawLine(MyPen, x0, 0, x0 + 10, 10);
            Graph.DrawLine(MyPen, (float)1.4 * x0 - 10, y0 - 10, (float)1.4 * x0, y0);
            Graph.DrawLine(MyPen, (float)1.4 * x0 - 10, y0 + 10, (float)1.4 * x0, y0);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graph.Clear(Color.White);
            int x1, y1, x2, y2;
            double x, y;
            double t = 0;
            double t1=0;
            //параметры
            int a;
            int b;
            int N=0;
            switch (WyborGraf.Text)
            {
                case "Улитка Паскаля": N = 0; t = 0; t1 = 6.27; break;
                case "Конхоида Никомеда": N = 1;t =-0.78;t1 =2.35; break;
                case "Эпициклоида": N = 2; t =0; t1 =6.27; break;
                case "Астроида": N = 3; t =0; t1 =6.27; break;
                case "Циссоида": N = 4; t =-20; t1 =20; break;
                case "Строфоида": N = 5; t =-2; t1 =2; break;
                case "Циклоида": N = 6; t =-5; t1 =5; break;
                case "Удлиненная и укороченная циклоида": N = 7; t =-5; t1 =5; break;
                case "Удлиненная гипоциклоида": N = 8; t =-5; t1 =5; break;
                case "Укороченная гипоциклоида": N = 9; t =-3; t1 =3; break;
                case "Архимедова спираль": N = 10; t =1; t1 =31.4; break;
                case "Логарифмическая спираль": N = 11; t =0; t1 =31.4; break;
                case "Эвольвента окружности": N = 12; t =-10; t1 =10; break;
                case "Лемниската Бернулли": N = 13; t =-0.78; t1 =4.78; break;
            }
            //фактические координаты в начальной точке заданного диапазона
            x = Grafic(N, t, 'x', Double.Parse(ParamA.Text), Double.Parse(ParamB.Text), Double.Parse(ParamK.Text)) ;
            y = Grafic(N, t, 'y', Double.Parse(ParamA.Text), Double.Parse(ParamB.Text), Double.Parse(ParamK.Text));

            //соответствующие им экранные координаты
            x1 = (int)(x0 + x * k);
            y1 = (int)(y0 - y * k);
            while (t < t1)
            {
                //определение фактических координат графика в следующей точке
                if (N == 13 && t > 0.76 && t < 1.6) t = 1.6;
                //  else
                //if (N == 1 && t > 1.57 && t <1.58) t = 1.59;
                t = t + step;
                x = Grafic(N, t, 'x', Double.Parse(ParamA.Text), Double.Parse(ParamB.Text), Double.Parse(ParamK.Text)); ;
                y = Grafic(N, t, 'y', Double.Parse(ParamA.Text), Double.Parse(ParamB.Text), Double.Parse(ParamK.Text)); ;
                //соответствующие им экранные координаты
                x2 = (int)(x0 + x * k);
                y2 = (int)(y0 - y * k);
                //вывод отрезка графика на экран
                Graph.DrawLine(MyPen, x1, y1, x2, y2);
                //запоминаем текущие координаты
                x1 = x2;
                y1 = y2;
            }
           // Grafic();
        }
        private double Grafic(int N, double t, char C, double a, double b, double k)
        {
            if(N==0)
            {
                if (C == 'x') return a * Math.Pow(Math.Cos(t), 2) + b * Math.Cos(t);
                else return a * Math.Cos(t) * Math.Sin(t) + b * Math.Sin(t);
            }
            else if(N==1)
            {
                if (C == 'x') return a + b * Math.Cos(t);
                else return a * Math.Tan(t) + b * Math.Sin(t);
            }
            else if(N==2)
            {
                if (C == 'x') return (a + b) * Math.Cos(t) - a * Math.Cos((a + b) * t / a);
                else return (a + b) * Math.Sin(t) - a * Math.Sin((a + b) * t / a);
            }
            else if (N==3)
            {
                if (C == 'x') return b * Math.Pow(Math.Cos(t), 3);
                else return b * Math.Pow(Math.Sin(t), 3);
            }
            else if (N == 4)
            {
                if (C == 'x') return a * t * t / (1 + t * t);
                else return a * t * t*t / (1 + t * t);
            }
            else if (N == 5)
            {
                if (C == 'x') return a * (t * t - 1) / (t * t + 1);
                else return a *t* (t * t - 1) / (t * t + 1);
            }
            else if (N == 6)
            {
                if (C == 'x') return a * (t - Math.Sin(t));
                else return a * (1 - Math.Cos(t));
            }
            else if (N == 7)
            {
                if (C == 'x') return a * (t - b * Math.Sin(t));
                else return a * (1 - b * Math.Cos(t));
            }
            else if (N == 8)
            {
                if (C == 'x') return (b - a) * Math.Cos(t) + k * a * Math.Cos((b - a) * t / a);
                else return (b - a)*Math.Sin(t) - k*a*Math.Sin((b - a)*t / a);
            }
            else if (N == 9)
            {
                if (C == 'x') return (b - a)*Math.Cos(t) + k * a * Math.Cos((b - a) * t / a);
                else return (b - a) * Math.Sin(t) - k * a * Math.Sin((b - a) * t / a);
            }//
            else if (N == 10)
            {
                if (C == 'x') return a * t * Math.Sin(t);
                else return a * t * Math.Cos(t);
            }
            else if (N == 11)
            {
                if (C == 'x') return a * Math.Pow(Math.E, b * t) * Math.Sin(t);
                else return a * Math.Pow(Math.E, b * t) * Math.Cos(t);
            }
            else if (N == 12)
            {
                if (C == 'x') return a * Math.Cos(t) + a * t * Math.Sin(t);
                else return a * Math.Sin(t) + a * t * Math.Cos(t);
            }
            else 
            {
                if (C == 'x') return Math.Sqrt(2*a*a*Math.Cos(2*t)) * Math.Sin(t);
                else return Math.Sqrt(2 * a *a* Math.Cos(2 * t)) * Math.Cos(t);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k/=2;
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            k *= 2;
            button1_Click(sender, e);
        }
    }
}

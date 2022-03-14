using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Анимация
{
    public partial class Form1 : Form
    {
        Graphics Graph;
        Pen MyPen;
        int X, Y, X1, Y1;
        Thread T1, T2, T3;

        public Form1()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyPen = new Pen(Color.Red, 12);
            T1 = new Thread(new ThreadStart(Zmejka));
            T2 = new Thread(new ThreadStart(Sputnic));
            T3 = new Thread(new ThreadStart(bilyard));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(T2.IsAlive) T2.Abort();
            if(T3.IsAlive) T3.Abort();
            Thread.Sleep(200);
            T1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (T1.IsAlive) T1.Abort();
            if (T3.IsAlive) T3.Abort();
            Thread.Sleep(200);
            T2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (T1.IsAlive) T1.Abort();
            if (T2.IsAlive) T2.Abort();
            Thread.Sleep(200);
            T3.Start();
        }

        private void Sputnic()
        {
            Graph.Clear(Color.Black);
            Graph.FillEllipse(Brushes.Blue, 500, 250, 100, 100);
            int x0 = 550;
            int y0 = 300;
            int k = 10;
            int x1, y1;
            double x, y;
            int R = 20;
            x = R;
            y = 0;

            //соответствующие им экранные координаты
            x1 = (int)(x0 + x * k);
            y1 = (int)(y0 - y * k);
            double i = 0;
            while (i < 100)
            {
                x = R * Math.Cos(i);
                y = R * Math.Sin(i);
                x1 = (int)(x0 + x * k);
                y1 = (int)(y0 - y * k);
                Graph.FillEllipse(Brushes.White, x1, y1, 10, 10);
                i += 0.01;
                Thread.Sleep(20);
                Graph.FillEllipse(Brushes.Black, x1, y1, 10, 10);

            }
        }
        
        private void bilyard()
        {
            Graph.Clear(Color.Aqua);
            Graph.FillRectangle(Brushes.Green, 325, 175, 400, 200);
            Graph.DrawRectangle(new Pen(Color.Black, 12), 325, 175, 400, 200);
            int x = 350;
            int y = 255;
            int k = 10;
            int Nap = 0, Nap1 = 0;
            //соответствующие им экранные координаты
            double ancle = 1.0;
            while (true)
            {
                Graph.FillEllipse(Brushes.White, x, y, 24, 24);
                if (Nap == 0)
                {

                    if (x > 688)
                    {
                        if (Nap1 == 1) ancle -= Math.PI / 2;
                        else ancle += Math.PI / 2;
                        Nap = 1;
                    }
                }
                if (Nap == 1)
                {
                    if (x < 337)
                    {
                        if (Nap1 == 1) ancle += Math.PI / 2;
                        else ancle -= Math.PI / 2;
                        Nap = 0;
                    }

                }
                if (Nap1 == 0)
                {
                    if (y > 339)
                    {
                        if (Nap == 0) ancle -= Math.PI / 2;
                        else ancle += Math.PI / 2;
                        Nap1 = 1;

                    }

                }
                if (Nap1 == 1)
                {
                    if (y < 187)
                    {
                        if (Nap == 1) ancle -= Math.PI / 2;
                        else ancle += Math.PI / 2;
                        Nap1 = 0;
                    }
                }
                Thread.Sleep(40);
                Graph.FillEllipse(Brushes.Green, x, y, 24, 24);
                x += (int)(Math.Cos(ancle) * 10);
                y += (int)(Math.Sin(ancle) * 10);

            }
        }

        private void Zmejka()
        {
            Graph.Clear(Color.White);
            Graph.DrawRectangle(MyPen, 200, 100, 500, 300);
            Graph.DrawLine(new Pen(Color.Green, 12), 180, 180, 180, 270);
            X = 180;
            Y = 180;
            X1 = 180;
            Y1 = 264;
            int Nap = 0, Nap1 = 0;
            while (true)
            {
                if (Nap == 0)
                {
                    Graph.DrawRectangle(new Pen(Color.Green, 12), X, Y, 6, 6);
                    //Graph.DrawLine(new Pen(Color.Green, 12), X, Y, X , Y - 12);
                    Y -= 6;
                    if (Y < 80) Nap = 1;
                }
                if (Nap == 1)
                {
                    Graph.DrawRectangle(new Pen(Color.Green, 12), X, Y, 6, 6);
                    X += 6;
                    if (X > 720) Nap = 2;
                }
                if (Nap == 2)
                {
                    Graph.DrawRectangle(new Pen(Color.Green, 12), X, Y, 6, 6);
                    Y += 6;
                    if (Y > 420) Nap = 3;
                }
                if (Nap == 3)
                {
                    Graph.DrawRectangle(new Pen(Color.Green, 12), X, Y, 6, 6);
                    X -= 6;
                    if (X < 170) Nap = 0;
                }
                if (Nap1 == 0)
                {
                    Graph.DrawRectangle(new Pen(Color.White, 12), X1, Y1, 6, 6);

                    Y1 -= 6;
                    if (Y1 < 80) Nap1 = 1;
                }
                if (Nap1 == 1)
                {
                    Graph.DrawRectangle(new Pen(Color.White, 12), X1, Y1, 6, 6);
                    X1 += 6;
                    if (X1 > 720) Nap1 = 2;
                }
                if (Nap1 == 2)
                {
                    Graph.DrawRectangle(new Pen(Color.White, 12), X1, Y1, 6, 6);
                    Y1 += 6;
                    if (Y1 > 420) Nap1 = 3;
                }
                if (Nap1 == 3)
                {
                    Graph.DrawRectangle(new Pen(Color.White, 12), X1, Y1, 6, 6);
                    X1 -= 6;
                    if (X1 < 170) Nap1 = 0;
                }
                Thread.Sleep(20);
            }
        }       
    }
}

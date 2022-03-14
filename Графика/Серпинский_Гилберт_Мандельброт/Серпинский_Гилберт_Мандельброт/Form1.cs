using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Серпинский_Гилберт_Мандельброт
{
    public partial class Form1 : Form
    {
        int xX, yY;
        Graphics Graph;
        Pen MyPen;
        double ugol;
        int x, y;
        int x0;
        int y0;
        public Form1()
        {
            InitializeComponent();
            MyPen = new Pen(Color.Black);
            Graph = CreateGraphics();
            yY = this.ClientSize.Height;
            xX = this.ClientSize.Width;

        }



        public class PointC
        {
            public int yA, yB, yC, xA, xB, xC;
            public PointC(int xA1, int xB1, int xC1, int yA1, int yB1, int yC1)
            {
                yA = yA1;
                yB = yB1;
                yC = yC1;
                xA = xA1;
                xB = xB1;
                xC = xC1;
            }
        }


        private void SS(PointC point, int n)
        {
            if (n > 0)
            {
                int yA = point.yA, yB = point.yB, yC = point.yC, xA = point.xA, xB = point.xB, xC = point.xC;
                Graph.DrawLine(MyPen, xA, yA, xB, yB);
                Graph.DrawLine(MyPen, xB, yB, xC, yC);
                Graph.DrawLine(MyPen, xC, yC, xA, yA);
                SS(new PointC((xA + xB) / 2, xA, (xA + xC) / 2, (yA + yB) / 2, yA, (yA + yC) / 2), n - 1);
                SS(new PointC(xC, (xC + xB) / 2, (xA + xC) / 2, yC, (yC + yB) / 2, (yA + yC) / 2), n - 1);
                SS(new PointC((xA + xB) / 2, (xC + xB) / 2, xB, (yA + yB) / 2, (yC + yB) / 2, yB), n - 1);

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graph.Clear(Color.White);
            SS(new PointC(0,450,900,780,0,780), 6);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            x = 0; y = 0;
            ugol = 0;
            x0 = x;
            y0 = y;
            Graph.Clear(Color.White);
            Lab(25, 5, 1);
        }

        private void Lab(int _dl, int Rr, int i)
        {
            if (Rr != 0)
            {
                ugol += i * Math.PI / 2;
                Lab(_dl, Rr - 1, -i);
                Step(ugol, _dl, ref x, ref y);

                ugol -= i * Math.PI / 2;
                Lab(_dl, Rr - 1, i);
                Step(ugol, _dl, ref x, ref y);

                Lab(_dl, Rr - 1, i);
                ugol -= i * Math.PI / 2;
                Step(ugol, _dl, ref x, ref y);

                Lab(_dl, Rr - 1, -i);
                ugol += i * Math.PI / 2;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graph.Clear(Color.White);
            Mandelbrot(3, -3, 3, -3);
        }

        private void Mandelbrot(double maxr, double minr, double maxi, double mini)
        {
            double zx = 0;
            double zy = 0;
            double cx = 0;
            double cy = 0;
            double xjump = (maxr - minr) / xX;
            double yjump = (maxi - mini) / yY;
            double tempzx = 0;
            //Размытость изображения
            int loopmax = 1000;
            int loopgo = 0;
            for (int x = 0; x < xX; x++)
            {
                cx = (xjump * x) - Math.Abs(minr);
                for (int y = 0; y < yY; y++)
                {
                    zx = 0;
                    zy = 0;
                    cy = (yjump * y) - Math.Abs(mini);
                    loopgo = 0;
                    while (zx * zx + zy * zy <= 4 && loopgo < loopmax)
                    {
                        loopgo++;
                        tempzx = zx;
                        zx = (zx * zx) - (zy * zy) + cx;
                        zy = (2 * tempzx * zy) + cy;
                    }
                    //Задание цветовой палитры отображения изображения
                    //Для внешнего окружения Множества Мандельброта
                    if (loopgo == loopmax) Graph.DrawRectangle(new Pen(Color.Red), x, y, 1, 1);

                }
            }
        }

        private void Step(double ugol, int _dl, ref int x, ref int y)
        {
            x += (int)(_dl * Math.Cos(ugol));
            y += (int)(_dl * Math.Sin(ugol));
            if (ugol % Math.PI == 0) Graph.DrawLine(MyPen, x, y, x0, y0);
            else Graph.DrawLine(MyPen, x, y, x0, y0);
            x0 = x;
            y0 = y;

        }
    }
}

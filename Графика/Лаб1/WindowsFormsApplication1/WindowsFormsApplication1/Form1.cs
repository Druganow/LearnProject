using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Graphics Graph;
        Pen MyPen, PenBR;
        Brush brush = Brushes.Red;
        Brush BrushGreen = Brushes.Green;
        Font font = new Font("Arial", 10);
        const double xMin = -20;
        const double xMax = 5;
        const double step = 0.01;
        const double k = 50;
        int x0;
        int y0;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyPen.Dispose();
            Graph.Dispose();
        }

        private void Grafic()
        {
            Graph.DrawLine(MyPen, 0, y0, (float)1.4 * x0, y0);
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
            Graph.DrawString("y=sin(1/2x)", font, brush, x0 - 190, y0 + 50);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


        }

        public Form1()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyPen = new Pen(Color.Black);
            PenBR = new Pen(Color.Brown, 4);
            x0 = this.ClientSize.Width / 2;
            y0 = this.ClientSize.Height / 2;

        }

        private void graf_Click(object sender, EventArgs e)
        {
            Graph.Clear(Color.White);
            int x1, y1, x2, y2;
            double x, y;

            //фактические координаты в начальной точке заданного диапазона
            x = xMin;
            y = Math.Sin(0.5 * x);
            //соответствующие им экранные координаты
            x1 = (int)(x0 + x * k);
            y1 = (int)(y0 - y * k);
            while (x < xMax)
            {
                //определение фактических координат графика в следующей точке
                x = x + step;
                y = Math.Sin(0.5 * x);
                //соответствующие им экранные координаты
                x2 = (int)(x0 + x * k);
                y2 = (int)(y0 - y * k);
                //вывод отрезка графика на экран
                Graph.DrawLine(MyPen, x1, y1, x2, y2);
                //запоминаем текущие координаты
                x1 = x2;
                y1 = y2;
            }
            Grafic();
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            Graph.Clear(Color.White);
            Graph.FillRectangle(Brushes.Green, 0, (float)(y0 + k), 2 * x0, y0);//трава
            Graph.FillRectangle(Brushes.Aqua, 0, 0, 2 * x0, (float)(y0 + k));//небо
            Graph.FillPolygon(Brushes.Black, new PointF[] { new PointF(x0, y0 - 300), new PointF(x0 - 100, y0 - 230), new PointF(x0 + 100, y0 - 230) });
            Graph.FillEllipse(Brushes.Wheat, x0 - 100, y0 - 260, 200, 100);//ротонда
            Graph.DrawEllipse(new Pen(Color.Black), x0 - 100, y0 - 260, 200, 100);
            Graph.FillRectangle(Brushes.Wheat, x0 - 70, y0 - 220, 140, 120);//ротонда квадратная
            Graph.FillRectangle(Brushes.Wheat, (float)(x0 - 10 * k), (float)(y0 - 2 * k), (float)(20 * k), (float)(5 * k)); //коробка
            Graph.FillPolygon(Brushes.Black, new PointF[] { new PointF(x0 + 460, y0 - 150), new PointF(x0 - 460, y0 - 150), new PointF(x0 - 510, y0 - 100), new PointF(x0 + 510, y0 - 100) });//крыша
            Graph.FillPolygon(Brushes.White, new PointF[] { new PointF(x0, y0 - 160), new PointF(x0 - 150, y0 - 80), new PointF(x0 + 150, y0 - 80) });//треугольник
            Graph.DrawPolygon(new Pen(Color.Black), new PointF[] { new PointF(x0, y0 - 160), new PointF(x0 - 150, y0 - 80), new PointF(x0 + 150, y0 - 80) });//треугоьник
            Graph.DrawRectangle(new Pen(Color.Black), x0 - 150, y0 - 80, 300, 20);//подтреугольник
            for (int i = 0; i < 17; i++)//окна
            {
                Graph.FillRectangle(Brushes.Black, (float)(20 + x0 - 10 * k + 58 * i), (float)(y0 - 2 * k + 58), 20, 40);
                Graph.DrawRectangle(PenBR, (float)(20 + x0 - 10 * k + 58 * i), (float)(y0 - 2 * k + 58), 20, 40);
            }
            for (int i = 0; i < 17; i++)//окна 2
            {
                Graph.FillRectangle(Brushes.Black, (float)(20 + x0 - 10 * k + 58 * i), (float)(y0 + k), 20, 40);
                Graph.DrawRectangle(PenBR, (float)(20 + x0 - 10 * k + 58 * i), (float)(y0 + k), 20, 40);
            }
            for (int i = 0; i < 6; i++)
            {
                Graph.FillRectangle(Brushes.White, x0 - 150 + 55 * i, y0 - 60, 25, 210);
                Graph.DrawRectangle(new Pen(Color.Black), x0 - 150 + 55 * i, y0 - 60, 25, 210);
            }
            Graph.FillEllipse(Brushes.Black, x0 - 20, y0 - 130, 40, 40);
        }
    }
}
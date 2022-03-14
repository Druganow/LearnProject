using System;
using System.Drawing;
using System.Windows.Forms;

namespace Контрольная_работа
{
    public partial class Form1 : Form
    {
        int xX, yY;
        Graphics Graph;
        Pen MyPen;

        private void button1_Click(object sender, EventArgs e)
        {
            Graph.Clear(Color.White);
            double a, b, c,d,a1,b1,c1,d1, x1,y1,x2,y2;
            a = b = c = d = a1 = b1 = c1 = d1 = x1 = y1 = x2 = y2 = 0;
            try
            {
                c = int.Parse(C_textBox.Text);
                a = int.Parse(A_textBox.Text);
                b = int.Parse(B_textBox.Text);
                d = int.Parse(D_textBox.Text);
                c1 = int.Parse(C1textBox.Text);
                a1 = int.Parse(A1textBox.Text);
                b1 = int.Parse(B1textBox.Text);
                d1 = int.Parse(D1textBox.Text);
                x1 = a;
                y1 = b;
                x2 = a1;
                y2 = b1;
            }
            catch { MessageBox.Show("Некорректные даные"); }
            double X, Y, X1, Y1;
            X = a;
            Y = a1;
            for (double i = 0.001; i < 1; i += 0.0001)
            {

                X1 = i * i * i * d + 3 * i * i * (1 - i) * c + 3 * i * (1 - i) * (1 - i) * b + (1 - i) * (1 - i) * (1 - i) * a;
                Y1 = i * i * i * d1 + 3 * i * i * (1 - i) * c1 + 3 * i * (1 - i) * (1 - i) * b1 + (1 - i) * (1 - i) * (1 - i) * a1;
                Graph.DrawLine(MyPen, (float)X, (float)Y, (float)X, (float)Y1);
                X = X1;
                Y = Y1;
            }
        }


        public Form1()
        {
            InitializeComponent();
            MyPen = new Pen(Color.Black, 2);
            Graph = CreateGraphics();
            xX = this.ClientSize.Width;
            yY = this.ClientSize.Height;
           
            
        }

    }
}

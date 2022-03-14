using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace График
{
    public partial class Form1 : Form
    {
        Graphics Graph;
        Random random;
        const int N = 100;
        int view = 200;
        int speed = 50;
        int[] x;
        int[] y;
        int[] z;
        int[] _x;
        int[] _y;
        int[] color;
        int i, gm, gd, gx, gy, xc, yc;

        private void button1_Click(object sender, EventArgs e)
        {
            Graph.Clear(Color.Black);
            for (int i = 0; i < N; i++)
            {
                x[i] = -10 * view + random.Next(20 * view);
                y[i] = -10 * view + random.Next(20 * view);
                z[i] = view + random.Next(20 * view);
            }
            gd = 0;
            xc = this.ClientSize.Width / 2;
            yc = this.ClientSize.Height / 2;
            while (true)
            {
                for (int i = 0; i < N; i++)
                {
                    if ((z[i] / (Math.Abs(x[i]) + 1) > view / xc) && (z[i] / (Math.Abs(y[i]) + 1) > view / yc))
                    {
                        _x[i] = xc + (int)(x[i] * (((double)view / z[i])));
                        _y[i] = yc + (int)(y[i] * (((double)view / z[i])));
                        Graph.DrawRectangle(new Pen(Color.White), _x[i], _y[i], 1, 1);//FromArgb(color[i], color[i], color[i])
                    }
                    else
                    {
                        z[i] = view + random.Next(20 * view);
                    }
                    
                }
                for (int i = 0; i < N; i++)
                {
                    z[i] -= speed;
                    if (z[i] < 4 * view) color[i] = 14;
                    else if (z[i] < 9 * view) color[i] = 11;
                    else color[i] = 9;
                }
                for (int i = 0; i < N; i++) Graph.DrawRectangle(new Pen(Color.Black), _x[i], _y[i], 1, 1);
            }
        }

        public Form1()
        {
            
            InitializeComponent();
            Graph = CreateGraphics();
            
            random = new Random();
            x = new int[N];
            y = new int[N];
            z = new int[N];
            _x = new int[N];
            _y = new int[N];
            color = new int[N];
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}

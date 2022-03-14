using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
   
    public partial class GRedactorForm : Form
    {
        String FileName = "";
        Graphics G;
        Bitmap bmp;
        Color newcolor1 = Color.Black; // выбранный в палитре цвет
        Color newcolor2 = Color.White;
        bool isEraser = false;
        GLine l; //для линий
        GRect r;//для прямоугольников
        public GRedactorForm()
        {
            InitializeComponent();
            bmp = new Bitmap(Field.Width, Field.Height);
            Field.Image = bmp;
            G = Graphics.FromImage(bmp);
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Field.Width, Field.Height);
            Field.Image = bmp;
            G = Graphics.FromImage(bmp);
        }

        public static Bitmap LoadBitmap(string file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                return new Bitmap(bm);
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                bmp = LoadBitmap(FileName);
                Text = "Графический редактор " + FileName;
                Field.Image = bmp;
                G = Graphics.FromImage(bmp);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = saveFileDialog1.FileName;
                bmp.Save(FileName);
            }
        }

        private void Field_MouseUp(object sender, MouseEventArgs e)
        {
            Field.Image = bmp;
            G = Graphics.FromImage(bmp);
            if (Pointtsb.Checked)
            {
                GPoint p = new GPoint(G);
                p.X = e.X;
                p.Y = e.Y;
                p.Draw(newcolor1, float.Parse(widthSCB.Text));
            }
            if (Linetsb.Checked)
            {

                l.LineEnd = new Point(e.X, e.Y);
                l.Draw(newcolor1, float.Parse(widthSCB.Text));
            }
             if (Recttsb.Checked)
            {
                r.Corner2 = new Point(e.X, e.Y);
                double control = controlwiht(double.Parse(widthSCB.Text), r.Corner1, r.Corner2);
                //изменение в зависимоти от типа
                if (LineHgtCB.Text == "Контур")
                    if (control == 0)
                        r.Draw(newcolor1,  float.Parse(widthSCB.Text));
                    else widthSCB.Text = ((int)control).ToString();
                if (LineHgtCB.Text == "Заливка")
                   
                    r.Draw(newcolor2);//надо уметь выбирать цвета
                if (LineHgtCB.Text == "Контур+заливка")
                    if (control == 0)
                        r.Draw(newcolor1, newcolor2, float.Parse(widthSCB.Text));//надо уметь выбирать цвета
                    else widthSCB.Text = ((int)control).ToString();
            }
        }

        private void ColorButton1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                newcolor1 = color.Color;
            ColorButton1.BackColor = newcolor1;
        }

        private void ColorButton2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                newcolor2 = color.Color;
            ColorButton2.BackColor = newcolor2;
        }

        private void Field_MouseDown(object sender, MouseEventArgs e)
        {
            //MouseDown = true;

            if (Linetsb.Checked)
            {
                l = new GLine(G);
                l.LineBeg = new Point(e.X, e.Y);
            }
            if (Recttsb.Checked)
            {
                r = new GRect(G);
                r.Corner1 = new Point(e.X, e.Y);
            }
        }
       
        public double controlwiht(double w, Point x1, Point x2)
        {
            if (w / 2 > Math.Min(Math.Abs(x1.X - x2.X), Math.Abs(x1.Y = x2.Y)))
            {

               // MessageBox.Show("Заданая ширина линии слишком большая, для такой маленькой фигуры, она была автоматически заменена на допустимую");
                if (Math.Min(Math.Abs(x1.X - x2.X), Math.Abs(x1.Y = x2.Y)) / 2 < 2) return 1;
                return Math.Min(Math.Abs(x1.X - x2.X), Math.Abs(x1.Y = x2.Y)) / 2;
            }
            else return 0;
        }

        private void LineHgtCB_Click(object sender, EventArgs e)
        {

        }

        private void заливкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// надо научиться выбирать цвет !!! ккак доступ получиить к протектед
/// добавить расширение при сохранении??? 
/// сохранить как вообще не написано
/// </summary>

namespace Lab5
{
    public partial class GRedactorForm : Form
    {
        bool fieldchange = false; // были изменнеия или нет(для сохраниения и открытия)
        String FileName = ""; // ни где не меняется надо это поравить дело
        Graphics G;
        Bitmap bmp;
        Color newcolor = Color.Black; // выбранный в палитре цвет
        Color newcolorback = Color.White;
        bool isEraser = false;
        bool MouseDown = false;
        GLine l ; //для линий
        GRect r;//для прямоугольников
        GEllips el;//элипстов
        public GRedactorForm()
        {
            InitializeComponent();
            toolStrip1.ImageList = imageList1;
            Pointtsb.ImageIndex = 0;
            Linetsb.ImageIndex = 1;
            Recttsb.ImageIndex = 2;
            Elipstsb.ImageIndex = 3;
            Erasertsb.ImageIndex = 4;
            Filltsb.ImageIndex = 5;
            //все что выше это картинки
            bmp = new Bitmap(Field.Width, Field.Height);
            Field.Image = bmp;
            G = Graphics.FromImage(bmp);
            l = new GLine(G);
            //чистый лист так сказать создали

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) //это создать тупая ты программа
        {
            if (fieldchange)//изенения были
            {
                DialogResult res = MessageBox.Show("Сохранить изменения в файле ?", "Сохранение", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    saveToolStripMenuItem1_Click(sender, e);//настящий сэйв
                    fieldchange = false;
                }
                else if (res == DialogResult.Cancel) return;
            }
            //создаем
            {
                bmp = new Bitmap(Field.Width, Field.Height);
                Field.Image = bmp;
                G = Graphics.FromImage(bmp);
                fieldchange = false;
            }
            FileName = "";
        }

        public static Bitmap LoadBitmap(string file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                return new Bitmap(bm);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)//это открыть что бты знал
        {
            openFileDialog1.Filter = "img files(*.jpeg;*.png;*.bmp)|*.jpeg;*.png;*.bmp |All files(*.*)|*.*";
            if (fieldchange)//измениения блыи?
            {
                DialogResult res = MessageBox.Show("Сохранить изменения в файле ?", "Сохранение", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    saveToolStripMenuItem1_Click(sender, e);//настящий сэйв
                    fieldchange = false;
                }
                else if (res == DialogResult.Cancel) return;
            }
            //открываем новый файл
            
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = openFileDialog1.FileName;
                    bmp = LoadBitmap(FileName);
                    Text = "Графический редактор " + FileName;
                    Field.Image = bmp;
                    G = Graphics.FromImage(bmp);
                    fieldchange = false;
                    
                }
            

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e) //вот это уже реальное сохранить
        {
            saveFileDialog1.Filter = "JPEG files(*.jpeg)|*.jpeg |PNG files(*.png*)|*.png*|PNG files(*.bmp*)|*.bmp*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = saveFileDialog1.FileName;
                if(saveFileDialog1.FilterIndex ==0)
                bmp.Save(FileName+".jpeg");
                if (saveFileDialog1.FilterIndex == 1)
                    bmp.Save(FileName + ".png");
                if (saveFileDialog1.FilterIndex == 2)
                    bmp.Save(FileName + ".bmp");
            }
        }

        private void Field_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            fieldchange = true;
            Field.Image = bmp;
            G = Graphics.FromImage(bmp);
            if (Pointtsb.Checked)
            {
                GPoint p = new GPoint(G);
                p.X = e.X;
                p.Y = e.Y;
                p.Draw(newcolor,float.Parse(widthSCB.Text));//точка рисуется только черная как №№№№№№ получить доступ к цвету??
            }
            if (Linetsb.Checked)
            {
                
                l.LineEnd = new Point(e.X, e.Y);
                l.Draw(newcolor, float.Parse(widthSCB.Text));
            }
            if (Recttsb.Checked)
            {
                r.Corner2 = new Point(e.X, e.Y);
                double control = controlwiht(double.Parse(widthSCB.Text), r.Corner1, r.Corner2);
                //изменение в зависимоти от типа
                if (LineHgtCB.Text == "Контур")
                    if (control == 0)
                        r.Draw(newcolor, Field.BackColor, float.Parse(widthSCB.Text));
                    else widthSCB.Text = ((int)control).ToString();
                if (LineHgtCB.Text == "Заливка")
                   
                    r.Draw(newcolorback);//надо уметь выбирать цвета
                if (LineHgtCB.Text == "Контур+заливка")
                    if (control == 0)
                        r.Draw(newcolor, newcolorback, float.Parse(widthSCB.Text));//надо уметь выбирать цвета
                    else widthSCB.Text = ((int)control).ToString();
            }
            if (Elipstsb.Checked)
            {
                el.Corner2 = new Point(e.X, e.Y);
                double control = controlwiht(double.Parse(widthSCB.Text), el.Corner1, el.Corner2);
                //изменение в зависимоти от типа
                if (LineHgtCB.Text == "Контур")
                    if (control == 0)
                        el.Draw(newcolor,Field.BackColor, float.Parse(widthSCB.Text));
                    else widthSCB.Text = ((int)control).ToString();
                if (LineHgtCB.Text == "Заливка")
                    el.Draw(newcolorback);//надо уметь выбирать цвета
                if (LineHgtCB.Text == "Контур+заливка")
                    if (control == 0)
                        el.Draw(newcolor, newcolorback, float.Parse(widthSCB.Text));//надо уметь выбирать цвета
                    else widthSCB.Text = ((int)control).ToString();
            }
        }

        private void Field_MouseDown(object sender, MouseEventArgs e)//тут мы только запоминаем координаты первого нажатия
        {
            
                 MouseDown = true;
            
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
            if (Elipstsb.Checked)
            {
                el = new GEllips(G);
                el.Corner1 = new Point(e.X, e.Y);
            }
        }

        private void Recttsb_Click(object sender, EventArgs e)
        {
            widthSCB.Enabled = true;
            LineHgtCB.Enabled = Recttsb.Checked || Elipstsb.Checked;
            Pointtsb.Checked = false;
            Linetsb.Checked = false;
            Elipstsb.Checked = false;//исключение одновременного выбора
            isEraser = false;
        }

        private void Pointtsb_Click(object sender, EventArgs e)
        {
            widthSCB.Enabled = true;
            LineHgtCB.Enabled = Recttsb.Checked || Elipstsb.Checked;
            Linetsb.Checked = false;
            Elipstsb.Checked = false;
            Recttsb.Checked = false;
            isEraser = false;
        }

        private void Linetsb_Click(object sender, EventArgs e)
        {
            widthSCB.Enabled = true;
            LineHgtCB.Enabled = Recttsb.Checked || Elipstsb.Checked;
            Recttsb.Checked = false;
            Pointtsb.Checked = false;
            Elipstsb.Checked = false;

            isEraser = false;

        }

        

        private void Elipstsb_Click(object sender, EventArgs e)
        {
            widthSCB.Enabled = true;
            LineHgtCB.Enabled = Recttsb.Checked || Elipstsb.Checked;
            Recttsb.Checked =false;//неодноврменно
            Pointtsb.Checked = false;
            Linetsb.Checked = false;
            isEraser = false;
        }

        private void LineHgtCB_Click(object sender, EventArgs e)
        {

        }

        private void Filltsb_Click(object sender, EventArgs e)//зливка фона
        {
            Field.Image = bmp;
            Field.BackColor = newcolorback;
            Field.Refresh();
            LineHgtCB.Enabled = false;
            widthSCB.Enabled = false;
            isEraser = false;
            Pointtsb.Checked = false;
            Linetsb.Checked = false;
            Recttsb.Checked = false;
            Elipstsb.Checked = false;
        }

        private void Erasertsb_ButtonClick(object sender, EventArgs e)
        {
                Pointtsb.Checked = false;
                Linetsb.Checked = false;
                Recttsb.Checked = false;
                Elipstsb.Checked = false;
            LineHgtCB.Enabled = false;
            widthSCB.Enabled = false;

            isEraser = true;
            
        }

        private void Field_MouseMove(object sender, MouseEventArgs e)
        {
            if (isEraser && MouseDown)
            {
                 if (кругToolStripMenuItem.Checked)
                {
                    if (большойToolStripMenuItem.Checked)
                    {
                        G.FillEllipse(new SolidBrush(Field.BackColor), e.X - 12, e.Y - 12, 25,  25);
                    }
                    else if (среднийToolStripMenuItem.Checked)
                    {
                        G.FillEllipse(new SolidBrush(Field.BackColor), e.X - 7, e.Y - 7,  15, 15);
                    }
                    else if (маленькийToolStripMenuItem.Checked)
                    {
                        G.FillEllipse(new SolidBrush(Field.BackColor), e.X - 2, e.Y - 2, 5, 5);
                        G.DrawEllipse(new Pen(Color.Black), e.X - 2, e.Y - 2,  5, 5);
                    }
                }
                else if(квадратToolStripMenuItem.Checked)
                {
                    if (большойToolStripMenuItem.Checked)
                    {
                        G.FillRectangle(new SolidBrush(Field.BackColor), e.X - 12, e.Y - 12,  25,  25);
                    }
                    else if (среднийToolStripMenuItem.Checked)
                    {
                        G.FillRectangle(new SolidBrush(Field.BackColor), e.X - 7, e.Y - 7,  15,  15);
                    }
                    else if (маленькийToolStripMenuItem.Checked)
                    {
                        G.FillRectangle(new SolidBrush(Field.BackColor), e.X - 2, e.Y - 2,  5, 5);
                    }
                }

            }
            Refresh();
            
        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            кругToolStripMenuItem.Checked = true;
            квадратToolStripMenuItem.Checked = false;
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            квадратToolStripMenuItem.Checked = true;
            кругToolStripMenuItem.Checked = false;
        }

        private void маленькийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            маленькийToolStripMenuItem.Checked = true;
            среднийToolStripMenuItem.Checked = false;
            большойToolStripMenuItem.Checked = false;
        }

        private void среднийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            маленькийToolStripMenuItem.Checked = false;
            среднийToolStripMenuItem.Checked = true;
            большойToolStripMenuItem.Checked = false;
        }

        private void большойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            маленькийToolStripMenuItem.Checked = false;
            среднийToolStripMenuItem.Checked = false;
            большойToolStripMenuItem.Checked = true;
        }

        private void Field_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)//полностью дублирует сохранить
        {
            saveFileDialog1.Filter = "JPEG files(*.jpeg)|*.jpeg |PNG files(*.png*)|*.png*|PNG files(*.bmp*)|*.bmp*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = saveFileDialog1.FileName;
                if (saveFileDialog1.FilterIndex == 0)
                    bmp.Save(FileName + ".jpeg");
                if (saveFileDialog1.FilterIndex == 1)
                    bmp.Save(FileName + ".png");
                if (saveFileDialog1.FilterIndex == 2)
                    bmp.Save(FileName + ".bmp");
            }
        }

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                newcolorback = color.Color;
            BackColorButton.BackColor = newcolorback;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                newcolor = color.Color;
            ColorButton.BackColor = newcolor;
        }

        public int controlwiht(double w, Point x1, Point x2)
        {
            if (w / 2 > Math.Min(Math.Abs(x1.X - x2.X), Math.Abs(x1.Y = x2.Y))) 
            {
                
                MessageBox.Show("Заданая ширина линии слишком большая, для такой маленькой фигуры, она была автоматически заменена на допустимую");
                if (Math.Min(Math.Abs(x1.X - x2.X), Math.Abs(x1.Y = x2.Y)) / 2 < 2) return 1;
                return Math.Min(Math.Abs(x1.X - x2.X), Math.Abs(x1.Y = x2.Y))/2;
            }
            else return 0;
        }

        private void GRedactorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fieldchange)//изенения были
            {
                DialogResult res = MessageBox.Show("Сохранить изменения в файле ?", "Сохранение", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    saveToolStripMenuItem1_Click(sender, e);//настящий сэйв
                    fieldchange = false;
                }
                else if (res == DialogResult.Cancel) e.Cancel = true; 
            }
        }

        private void widthSCB_Click(object sender, EventArgs e)
        {

        }
    }
}

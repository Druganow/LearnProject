using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {

        Graphics Graph;
        Color[] PointsColors = new Color[] { Color.Red, Color.Blue, Color.Green };
        double M1, M2, M3;
        double X1, X2, X3;
        double Y1, Y2, Y3;
        double dX1, dX2, dX3;
        double dY1, dY2, dY3;

        double DT, T_max;

        const double start = 0;
        List<Point[]> Points = new List<Point[]>();

        public Form1()
        {
            InitializeComponent();
            Graph = pictureBox1.CreateGraphics();
        }


        private void ResButton_Click(object sender, EventArgs e)
        {
            if (CheckAllTextBoxes())
            {
                Graph.Clear(pictureBox1.BackColor);
                double[] param0 = new double[] {
                    start, X1,dX1,Y1,dY1,
                            X2,dX2,Y2,dY2,
                             X3,dX3,Y3,dY3 };

                RungeKutt(param0, T_max, DT);
                PrintAllPoints(Graph, Points);
            }

        }
        //проверка всех TB и заполение переменных значениями этих TB
        private bool CheckAllTextBoxes()
        {
            return
                CheckTextBox(M1textBox, out M1) &&
                 CheckTextBox(M2textBox, out M2) &&
                  CheckTextBox(M3textBox, out M3) &&

                   CheckTextBox(X1textBox, out X1) &&
                    CheckTextBox(X2textBox, out X2) &&
                     CheckTextBox(X3textBox, out X3) &&

                        CheckTextBox(Y1textBox, out Y1) &&
                    CheckTextBox(Y2textBox, out Y2) &&
                     CheckTextBox(Y3textBox, out Y3) &&

                        CheckTextBox(PX1textBox, out dX1) &&
                    CheckTextBox(PX2textBox, out dX2) &&
                     CheckTextBox(PX3textBox, out dX3) &&

                     CheckTextBox(PY1textBox, out dY1) &&
                    CheckTextBox(PY2textBox, out dY2) &&
                     CheckTextBox(PY3textBox, out dY3) &&

                     CheckTextBox(dTtextBox, out DT) &&
                      CheckTextBox(T_MAXtextBox, out T_max)
                ;
        }

        private bool CheckTextBox(TextBox textBox, out double a)
        {
            if (textBox.TextLength == 0) textBox.Text = "0";
            if (!double.TryParse(textBox.Text.Replace('.', ','), out a))
            {
                textBox.Focus();
                MessageBox.Show("Не во всех полях верно установленны значения");
                return false;
            }
            return true;
        }

        private bool CheckTextBox(TextBox textBox, out int a)
        {
            if (textBox.TextLength == 0) textBox.Text = "0";
            if (!int.TryParse(textBox.Text, out a))
            {
                textBox.Focus();
                MessageBox.Show("Не во всех полях верно установленны значения");
                return false;
            }
            return true;
        }


        //Метод Рунге-Кутта 4ого порядка
        List<double[]> RungeKutt(double[] param0, double t_max, double step_t)
        {
            int n = (int)(t_max / step_t);
            //координаты точек для рисования
            Points = new List<Point[]>(n);
            List<double[]> param_list = new List<double[]>();
            //расчёт параметров 2ого и 3его порядка. 
            double[] getParams2(double[] param, double[] k)
            {

                double[] res = new double[DiffSystemOfEqual.PARAMS_COUNT];
                res[0] = param_list.Last()[0] + step_t / 2;
                for (int i = 1; i < DiffSystemOfEqual.PARAMS_COUNT; i++)
                {
                    res[i] = param[i] + (k[i] / 2);
                }
                return res;
            }
            //расчёт параметров. 4ого порядка
            double[] getParams4(double[] param, double[] k3)
            {
                double[] res = new double[DiffSystemOfEqual.PARAMS_COUNT];
                res[0] = param_list.Last()[0] + step_t;
                for (int i = 1; i < DiffSystemOfEqual.PARAMS_COUNT; i++)
                {
                    res[i] = param[i] + k3[i];
                }
                return res;
            }



            // установка константных данных: массы
            param_list.Add(param0);
            DiffSystemOfEqual.m1 = M1;
            DiffSystemOfEqual.m2 = M2;
            DiffSystemOfEqual.m3 = M3;
            DiffSystemOfEqual p1 = new DiffSystemOfEqual(param0);
            Points.Add(p1.GetCoord());
            for (int i = 1; i < n; i++)
            {
                //Коэфициенты первого порядка
                double[] k1 = p1.GetRes(step_t);

                //Коэфициенты второго порядка
                DiffSystemOfEqual p2 = new DiffSystemOfEqual(getParams2(param_list[i - 1], k1));
                double[] k2 = p2.GetRes(step_t);
                //Коэфициенты 3его порядка
                DiffSystemOfEqual p3 = new DiffSystemOfEqual(getParams2(param_list[i - 1], k2));
                double[] k3 = p3.GetRes(step_t);

                //Коэф 4ого порядка
                DiffSystemOfEqual p4 = new DiffSystemOfEqual(getParams4(param_list[i - 1], k3));
                double[] k4 = p4.GetRes(step_t);

                //Следующие значения параметров:
                param_list.Add(new double[DiffSystemOfEqual.PARAMS_COUNT]);

                for (int m = 0; m < DiffSystemOfEqual.PARAMS_COUNT; m++)
                    param_list[i][m] = param_list[i - 1][m] + (k1[m] + 2 * k2[m] + 2 * k3[m] + k4[m]) / 6;
               
                p1 = new DiffSystemOfEqual(param_list[i]); 
                Points.Add(p1.GetCoord());
            }
            return param_list;

        }
        void PrintAllPoints(Graphics gr, List<Point[]> points)
        {
            for (int i = 0; i < points.Count; i++)
            {
                for (int k = 0; k < points[i].Length; k++)
                {
                    try
                    {
                        gr.FillEllipse(new SolidBrush(PointsColors[k]), points[i][k].X + pictureBox1.Width / 2, -points[i][k].Y + pictureBox1.Height / 2, 4, 4);
                    }
                    catch
                    {
                        break;
                    }
                }
            }
        }

    }
}

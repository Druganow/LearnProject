using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3.Динамика_популяции_видов
{
    public partial class Form1 : Form
    {
        static double
            a1 = -0.001, a2 = -0.001,
            b12 = 0.00001, b21 = 0,
            c1 = 0, c2 = 0,
            x1_0 = 10, x2_0 = 1000,
            t0 = 0, t_end = 10000, dt = 1;

        public Form1()
        {
            InitializeComponent();
            PrintInpTable();
            SetValTable();

            ResButton_Click(this, null);
        }

        /// <summary>
        /// Метод Рунге-Кутта 4ого порядка
        /// </summary>
        /// <param name="param0">начальные значения параметров: t,x0, x`0</param>
        /// <param name="end_t">конечное значение времени t</param>
        /// <param name="step_t">шаг t</param>
        /// <returns></returns>
        List<double[]> RungeKutt(double[] param0, double end_t, double step_t)
        {
            int n = (int)((end_t - param0[0]) / dt);

            List<double[]> param_list = new List<double[]>();
            double[] getParams2(double[] param, double[] k)
            {

                double[] res = new double[SoODE.PARAMS_COUNT];
                res[0] = param_list.Last()[0] + step_t / 2;
                for (int i = 1; i < SoODE.PARAMS_COUNT; i++)
                {
                    res[i] = param[i] + (k[i] / 2);
                }
                return res;
            }
            double[] getParams4(double[] param, double[] k3)
            {
                double[] res = new double[SoODE.PARAMS_COUNT];
                res[0] = param_list.Last()[0] + step_t;
                for (int i = 1; i < SoODE.PARAMS_COUNT; i++)
                {
                    res[i] = param[i] + k3[i];
                }
                return res;
            }



            //начальные данные
            param_list.Add(param0);
           
            for (int i = 1; i < n; i++)
            {
                SoODE p1 = new SoODE(param_list[i - 1]);
                //Коэфициенты первого порядка
                double[] k1 = p1.GetRes(step_t);

                //Коэфициенты второго порядка
                SoODE p2 = new SoODE(getParams2(param_list[i - 1], k1));
                double[] k2 = p2.GetRes(step_t);
                //Коэфициенты 3его порядка
                SoODE p3 = new SoODE(getParams2(param_list[i - 1], k2));
                double[] k3 = p3.GetRes(step_t);

                //Коэф 4ого порядка
                SoODE p4 = new SoODE(getParams4(param_list[i - 1], k3));
                double[] k4 = p4.GetRes(step_t);

                //Следующие значения параметров:
                param_list.Add(new double[SoODE.PARAMS_COUNT]);

                for (int m = 1; m < SoODE.PARAMS_COUNT; m++)
                {
                    param_list[i][m] = param_list[i - 1][m] + (k1[m] + 2 * k2[m] + 2 * k3[m] + k4[m]) / 6;
                    if (param_list[i][m] < 0) param_list[i][m] = 0;
                }
                   
                param_list[i][0] = param_list[i - 1][0] + step_t;
            }
            return param_list;

        }

        private void ResButton_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                SoODE.a1 = a1;
                SoODE.a2 = a2;
                SoODE.b12 = b12;
                SoODE.b21 = b21;
                SoODE.c1 = c1;
                SoODE.c2 = c2;
                //начальные данные
                double[] param0 = new double[] {
                    t0,x1_0,x2_0 };

                List<double[]> Params = RungeKutt(param0, t_end, dt);
                List<double[]> Res = new List<double[]>(100);
                int k = Params.Count / 100;
                if (k == 0) k = 1;
                for (int i = 0; i < Params.Count; i++)
                {
                    if (i % k == 0 && Params[i][1]<Math.Pow(10,20) && Params[i][2] < Math.Pow(10, 20)) Res.Add(Params[i]);
                }
                /*
                //сохраняю данные в файл на всякий пожарный
                SaveRes(Res);
                */
                chart.Visible = chart1.Visible = false;

                chart.ChartAreas[0].AxisX.Minimum = 0;
                chart.ChartAreas[0].AxisX.Maximum = t_end + 5;

                //заносим точки
                //График популяции 1ого вида
                chart.Series[0].Points.Clear();
                chart.Series[0].Points.DataBindXY(Res.Select(x => Math.Round(x[0],5)).ToArray(), Res.Select(x => Math.Round(x[1], 5)).ToArray());

                //График популяции 2ого вида
                chart.Series[1].Points.Clear();
                chart.Series[1].Points.DataBindXY(Res.Select(x => Math.Round(x[0], 5)).ToArray(), Res.Select(x=>Math.Round(x[2], 5)).ToArray());
                
                //фазовый портрет
                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.DataBindXY(Res.Select(x=>Math.Round(x[1], 5)).ToArray(), Res.Select(x=>Math.Round(x[2], 5)).ToArray());

                // выделяем первую точку.
                chart.Series[0].Points[0].MarkerStyle = MarkerStyle.Circle;
                chart.Series[0].Points[0].MarkerSize = 10;

                chart.Series[1].Points[0].MarkerStyle = MarkerStyle.Circle;
                chart.Series[1].Points[0].MarkerSize = 10;

                chart1.Series[0].Points[0].MarkerStyle = MarkerStyle.Circle;
                chart1.Series[0].Points[0].MarkerColor = Color.Red;
                chart1.Series[0].Points[0].MarkerSize = 10;


                chart.Visible = chart1.Visible = true;
            }
        }


        /// <summary>
        /// взять данные из таблицы
        /// </summary>
        /// <returns>true в случае успеха</returns>
        private bool GetData()
        {
            return
                GetDataFromTB(InpTable.Controls[10], out a1) &&
                GetDataFromTB(InpTable.Controls[11], out a2) &&
                GetDataFromTB(InpTable.Controls[12], out b12) &&
                GetDataFromTB(InpTable.Controls[13], out b21) &&
                GetDataFromTB(InpTable.Controls[14], out c1) &&
                GetDataFromTB(InpTable.Controls[15], out c2) &&
                GetDataFromTB(InpTable.Controls[16], out x1_0) &&
                GetDataFromTB(InpTable.Controls[17], out x2_0) &&
                GetDataFromTB(InpTable.Controls[18], out dt) &&
                GetDataFromTB(InpTable.Controls[19], out t_end);

        }
        private bool GetDataFromTB(Control tb, out double res)
        {
            tb.Text = tb.Text.Replace('.', ',');
            if (!double.TryParse(tb.Text, out res))
            {
                tb.Focus();
                MessageBox.Show("Ошибка ввода в поле " + tb.Text);
                return false;
            }
            return true;
        }

        bool GetInpArr(int num, out double res)
        {
            if (!double.TryParse(InpTable.Controls[num * 2 + 1].Text.Replace(".", ","), out res))
            {
                InpTable.Controls[num * 2 + 1].Focus();
                MessageBox.Show("Ошибка ввода значения: " + InpTable.Controls[num * 2].Text);
                return false;
            }
            return true;
        }
        void SetValTable()
        {
            InpTable.Controls[10].Text = "" + a1;
            InpTable.Controls[11].Text = "" + a2;
            InpTable.Controls[12].Text = "" + b12;
            InpTable.Controls[13].Text = "" + b21;
            InpTable.Controls[14].Text = "" + c1;
            InpTable.Controls[15].Text = "" + c2;
            InpTable.Controls[16].Text = "" + x1_0;
            InpTable.Controls[17].Text = "" + x2_0;
            InpTable.Controls[18].Text = "" + dt;
            InpTable.Controls[19].Text = "" + t_end;
        }
        void PrintInpTable()
        {
            InpTable.Controls.Clear();

            InpTable.ColumnCount = 2;
            InpTable.RowCount = 10;
            AddLabelInTable(InpTable, "a1", 0, 0, Color.Aqua);
            AddLabelInTable(InpTable, "a2", 1, 0, Color.Aqua);
            AddLabelInTable(InpTable, "b12", 2, 0, Color.Aqua);
            AddLabelInTable(InpTable, "b21", 3, 0, Color.Aqua);
            AddLabelInTable(InpTable, "c1", 4, 0, Color.Aqua);
            AddLabelInTable(InpTable, "c2", 5, 0, Color.Aqua);
            AddLabelInTable(InpTable, "x1_0", 6, 0, Color.Aqua);
            AddLabelInTable(InpTable, "x2_0", 7, 0, Color.Aqua);
            AddLabelInTable(InpTable, "dt", 8, 0, Color.Aqua);
            AddLabelInTable(InpTable, "t end", 9, 0, Color.Aqua);
            for (int i = 0; i < 10; i++)
            {
                AddTextBoxInTable(i, 1, Color.Azure);
            }

        }
        void AddLabelInTable(TableLayoutPanel Table, string text, int i, int j, Color BackColor)
        {
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.BackColor = BackColor;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = text;
            Table.Controls.Add(label, j, i);

        }
        void AddTextBoxInTable(int i, int j, Color BackColor, Object text = null)
        {
            TextBox TB = new TextBox();
            TB.Dock = DockStyle.Fill;
            TB.BackColor = BackColor;
            if (text != null) TB.Text = text.ToString();
            InpTable.Controls.Add(TB, j, i);
        }
    }
}

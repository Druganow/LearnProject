using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MM_L2.SelfOscillatingSystem
{
    public partial class FormMain : Form
    {
        List<double[]> Res = new List<double[]>();
        static double a1 = 1, a2 = 0.1, b = 2,
            h = 0, p = 1, t_end = 20, dt = 0.001,
            x0 = -1, x_pr0 = 0, t0 = 0;
        static double b1 = b;

        public FormMain()
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

                for (int m = 0; m < SoODE.PARAMS_COUNT; m++)
                    param_list[i][m] = param_list[i - 1][m] + (k1[m] + 2 * k2[m] + 2 * k3[m] + k4[m]) / 6;

            }
            return param_list;

        }

        private void ResButton_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                SoODE.a1 = a1;
                SoODE.a2 = a2;
                SoODE.b = b;
                SoODE.b1 = b1;
                SoODE.h = h;
                SoODE.p = p;
                //начальные данные
                double[] param0 = new double[] { t0, x0, x_pr0 };

                List<double[]> Params = RungeKutt(param0, t_end, dt);
                List<double[]> Res = new List<double[]>(100);
                int k = Params.Count / 100;
                if (k == 0) k = 1;
                for (int i = 0; i < Params.Count; i++)
                {
                    if (i % k == 0 && Params[i][1] < Math.Pow(10, 20) && Params[i][2] < Math.Pow(10, 20)) Res.Add(Params[i]);
                }
                /*
                //сохранение данных в файл
                SaveRes(Res);
                */
                chart.Visible = chart1.Visible = false;
                // Настройка оси графика
                chart.ChartAreas[0].AxisX.Minimum = 0;
                chart.ChartAreas[0].AxisX.Maximum = t_end;

                // Определение шага сетки
                chart.Series[0].Points.Clear();
                chart.Series[0].Points.DataBindXY(Res.Select(x=>x[0]).ToArray(), Res.Select(x=>x[1]).ToArray());

                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.DataBindXY(Res.Select(x =>Math.Round(x[1],5)).ToArray(), Res.Select(x => Math.Round(x[2], 5)).ToArray());
                // выделяем первую точку.
                chart.Series[0].Points[0].MarkerStyle = MarkerStyle.Circle;
                chart.Series[0].Points[0].MarkerSize = 4;

                chart1.Series[0].Points[0].MarkerStyle = MarkerStyle.Circle;
                chart1.Series[0].Points[0].MarkerSize = 4;


                chart.Visible = chart1.Visible = true;
            }
        }

        /// <summary>
        /// Сохранение полученных данных в файл
        /// </summary>
        /// <param name="res"></param>
        void SaveRes(List<double[]> res)
        {
            string filename = "result.txt";
            StreamWriter sw = File.CreateText(filename);
            sw.WriteLine("t\t\tx\t\tx'\t\t");
            for (int i = 0; i < res.Count; i ++) 
            {
                string str = "";
                for (int m = 0; m < res[i].Count(); m++)
                {
                    str += String.Format("{0}\t\t", Math.Round(res[i][m], 1));
                }
                sw.WriteLine(str);
            }
            sw.Close();
            MessageBox.Show("добавленно в файл");
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
                GetDataFromTB(InpTable.Controls[12], out b) &&
                GetDataFromTB(InpTable.Controls[13], out b1) &&
                GetDataFromTB(InpTable.Controls[14], out h) &&
                GetDataFromTB(InpTable.Controls[15], out p) &&
                GetDataFromTB(InpTable.Controls[16], out x0) &&
                GetDataFromTB(InpTable.Controls[17], out x_pr0) &&
                GetDataFromTB(InpTable.Controls[18], out dt) &&
                GetDataFromTB(InpTable.Controls[19], out t_end);
        }
        
        private bool GetDataFromTB(Control tb, out double res)
        {
            tb.Text = tb.Text.Replace('.', ',');
            if (!double.TryParse(tb.Text, out res)){
                tb.Focus();
                MessageBox.Show("Ошибка ввода в поле " + tb.Text);
                return false;
            }
            return true;
        }

        bool GetInpArr(int num, out double res)
        {
            if (!double.TryParse(InpTable.Controls[num*2 + 1].Text.Replace(".", ","), out res))
            {
                InpTable.Controls[num*2 + 1].Focus();
                MessageBox.Show("Ошибка ввода значения: " + InpTable.Controls[num*2].Text);
                return false;
            }
            return true;
        }
        
        void SetValTable()
        {
            InpTable.Controls[10].Text = "" + a1;
            InpTable.Controls[11].Text = "" + a2;
            InpTable.Controls[12].Text = "" + b;
            InpTable.Controls[13].Text = "" + b1;
            InpTable.Controls[14].Text = "" + h;
            InpTable.Controls[15].Text = "" + p;
            InpTable.Controls[16].Text = "" + x0;
            InpTable.Controls[17].Text = "" + x_pr0;
            InpTable.Controls[18].Text = "" + dt;
            InpTable.Controls[19].Text = "" + t_end;
        }
        
        void PrintInpTable()
        {
            InpTable.Controls.Clear();

            InpTable.ColumnCount = 2;
            InpTable.RowCount = 10;
            AddLabelInTable(InpTable, "a1", 0, 0, Color.Yellow);
            AddLabelInTable(InpTable, "a2", 1, 0, Color.Yellow);
            AddLabelInTable(InpTable, "b", 2, 0, Color.Yellow);
            AddLabelInTable(InpTable, "b1", 3, 0, Color.Yellow);
            AddLabelInTable(InpTable, "h", 4, 0, Color.Yellow);
            AddLabelInTable(InpTable, "p", 5, 0, Color.Yellow);
            AddLabelInTable(InpTable, "x0", 6, 0, Color.Yellow);
            AddLabelInTable(InpTable, "x'0", 7, 0, Color.Yellow);
            AddLabelInTable(InpTable, "dt", 8, 0, Color.Yellow);
            AddLabelInTable(InpTable, "t last", 9, 0, Color.Yellow);
            for (int i = 0; i < 10; i++)
            {
                AddTextBoxInTable(i, 1, Color.White);
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

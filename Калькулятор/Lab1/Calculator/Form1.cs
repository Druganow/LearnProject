using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculator
{
    public partial class Form1 : Form
    {
        private SS PreSyst = SS.Dec;
        public CalcSystem opr1;
        public CalcSystem opr2;
        private double operand1;
        private string Op;
        string operand1_;

        public Form1()
        {
            InitializeComponent();

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (Op == "k")
            { NumberTextBox.Text = "0"; Op = ""; }
            if (NumberTextBox.Text == "0") NumberTextBox.Text = (sender as Button).Text;
            else NumberTextBox.Text = NumberTextBox.Text + (sender as Button).Text;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ////сохраняем значение числа в переменной operand1
            //operand1 = double.Parse(NumberTextBox.Text);
            ////обнуляем содержимое окна ввода
            //NumberTextBox.Text = "0";
            ////сохраняем значение арифметической операции
            ////в переменной Op
            //Op = (sender as Button).Text;
            opr1 = new CalcSystem(NumberTextBox.Text, PreSyst);
            NumberTextBox.Text = "0";
            if (sender is Button)
                Op = ((Button)sender).Text;
            else
                Op = "" + (char)sender;
        }
        //
        private void PointButton_Click(object sender, EventArgs e)
        {
            //если в записи числа еще нет символа ','
            double few = Double.Parse(NumberTextBox.Text);
            if (!(few.Equals(Double.NaN) || NumberTextBox.Text.Contains(',') || few.Equals(Double.PositiveInfinity) || few.Equals(Double.NegativeInfinity))) NumberTextBox.Text = NumberTextBox.Text + ",";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            opr2 = new CalcSystem(NumberTextBox.Text, PreSyst);
            if (PreSyst == SS.Bin)
            {
                string Result1 = "";
                string operand2_ = NumberTextBox.Text;
                switch (Op)
                {
                    case "or": Result1 = Or(operand1_, operand2_); break;
                    case "and": Result1 = And(operand1_, operand2_); break;
                }
                NumberTextBox.Text = Result1;
            }
            else
            {
                double Result = 0;
                //сохраняем значение второго операнда
                //в переменной operand2

                //сохраняем значение второго операнда
                //в переменной operand2


                //double operand2 = double.Parse(NumberTextBox.Text);
                switch (Op)
                {   //в зависимости от знака операции
                    //вычисляем выражение
                    //case "+": Result = operand1 + operand2; break;
                    //case "-": Result = operand1 - operand2; break;
                    //case "*": Result = operand1 * operand2; break;
                    //case "/": Result = operand1 / operand2; break;
                    //case "^": Result = Math.Pow(operand1, operand2); break;

                    case "+":
                        NumberTextBox.Text = (opr1 + opr2).ToString();
                        break;
                    case "-":
                        NumberTextBox.Text = (opr1 - opr2).ToString();
                        break;
                    case "*":
                        NumberTextBox.Text = (opr1 * opr2).ToString();
                        break;
                    case "/":
                        NumberTextBox.Text = (opr1 / opr2).ToString();
                        break;
                    case "&&":
                        NumberTextBox.Text = (opr1 & opr2).Bin;
                        break;
                    case "|":
                        NumberTextBox.Text = (opr1 | opr2).Bin;
                        break;
                    case "x^n":
                        NumberTextBox.Text = Math.Pow(opr1, opr2).ToString();
                        break;
                }
                //NumberTextBox.Text = Result.ToString();
                Op = "k";
                
            }
        }

        //static string SS(string s, int ss1, int ss2)
        //{
        //    long number = 0;
        //    int[] a = new int[s.Length];
        //    if (ss1 == 10) number = (int)double.Parse(s);
        //    else
        //    {
        //        for (int i = 0; i < s.Length; i++)
        //        {
        //            if (s[i] == 'a') a[i] = 10;
        //            else if (s[i] == 'b') a[i] = 11;
        //            else if (s[i] == 'c') a[i] = 12;
        //            else if (s[i] == 'd') a[i] = 13;
        //            else if (s[i] == 'e') a[i] = 14;
        //            else if (s[i] == 'f') a[i] = 15;
        //            else a[i] = (int)s[i] - 48;

        //        }

        //    }

        //    for (int i = 0; i < s.Length; i++)
        //        {
        //            number += a[s.Length - i - 1] * (int)Math.Pow(ss1, i);
        //        }
        //        return Convert.ToString(number, ss2);
        //    }

            static string Or(string s1, string s2)
            {
                string s;
                if (s1.Length != s2.Length)
                {
                    if (s1.Length < s2.Length)
                    {
                        s = s1;
                        s1 = s2;
                        s2 = s;
                    }
                    int n = s1.Length - s2.Length;
                    for (int i = 0; i < n; i++) s2 = "0" + s2;
                }
                s = "";
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == '1' || s2[i] == '1') s += "1";
                    else s += "0";
                }
            int g = 0;
            if (s.Length != 1) while (s[g] == '0' && g != s.Length - 1) g++;
            s = s.Remove(0, g);
            return s;
            }

            static string And(string s1, string s2)
            {
                string s;
                if (s1.Length != s2.Length)
                {
                    if (s1.Length < s2.Length)
                    {
                        s = s1;
                        s1 = s2;
                        s2 = s;
                    }
                    int n = s1.Length - s2.Length;
                    for (int i = 0; i < n; i++) s2 = "0" + s2;
                }
                s = "";
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == '1' && s2[i] == '1') s += "1";
                    else s += "0";
                }
            int g = 0;
            if (s.Length != 1) while (s[g] == '0' && g != s.Length - 1) g++;
            s = s.Remove(0, g);
            return s;
            }

            private void CancelButton_Click(object sender, EventArgs e)
            {
                NumberTextBox.Text = "0";
            operand1 = 0;
            operand1_ = "";
            Op = "";
            }

            private void Form1_KeyPress(object sender, KeyPressEventArgs e)
            {

                if (PreSyst == SS.Hex)
                {
                if (Op == "k")
                { NumberTextBox.Text = "0"; Op = ""; }
                if (e.KeyChar == 'a' || e.KeyChar == 'b' || e.KeyChar == 'c' || e.KeyChar == 'd' || e.KeyChar == 'f' || e.KeyChar == 'ф' || e.KeyChar == 'и' || e.KeyChar == 'с' || e.KeyChar == 'в' || e.KeyChar == 'а')
                    {
                  
                    if (NumberTextBox.Text == "0") NumberTextBox.Text = e.KeyChar.ToString();
                        else NumberTextBox.Text = NumberTextBox.Text + e.KeyChar;
                    }
                    if (char.IsDigit(e.KeyChar))
                    {
                        if (NumberTextBox.Text == "0") NumberTextBox.Text = e.KeyChar.ToString();
                        else NumberTextBox.Text = NumberTextBox.Text + e.KeyChar;
                    }
                }
                if (PreSyst == SS.Dec)
                {
                     if (Op == "k")
                    { NumberTextBox.Text = "0"; Op = ""; }
                if (char.IsDigit(e.KeyChar))
                    {
                   
                    if (NumberTextBox.Text == "0") NumberTextBox.Text = e.KeyChar.ToString();
                        else NumberTextBox.Text = NumberTextBox.Text + e.KeyChar;
                    }
                    switch (e.KeyChar)
                    {
                        case '/': AddButton_Click(DivButton, e); break;
                        case '*': AddButton_Click(MultiplyButton, e); break;
                        case '-': AddButton_Click(SubtractButton, e); break;
                        case '+': AddButton_Click(AddButton, e); break;
                        Op = "k";
                        //    case '=': case '\r': AddButton_Click(EqualButton, e); break;
                }
                }
                if (PreSyst == SS.Oct)
                {
                    if (Op == "k")
                    { NumberTextBox.Text = "0"; Op = ""; }
                if (char.IsDigit(e.KeyChar) && !(e.KeyChar == '8' || e.KeyChar == '9'))
                    {
                    
                    if (NumberTextBox.Text == "0") NumberTextBox.Text = e.KeyChar.ToString();
                        else NumberTextBox.Text = NumberTextBox.Text + e.KeyChar;
                    }
                }
                if (PreSyst == SS.Bin)
                {
                if (Op == "k")
                { NumberTextBox.Text = "0"; Op = ""; }
                if (e.KeyChar == '0' || e.KeyChar == '1')
                    {
                    
                    if (NumberTextBox.Text == "0") NumberTextBox.Text = e.KeyChar.ToString();
                        else NumberTextBox.Text = NumberTextBox.Text + e.KeyChar;
                    }
                }
                if (e.KeyChar == 8)
                {
                if (NumberTextBox.Text.Equals("не число")) NumberTextBox.Text = "0";
                    if (NumberTextBox.Text.Length == 1) NumberTextBox.Text = "0";
                    if (NumberTextBox.Text.Length != 1) NumberTextBox.Text = NumberTextBox.Text.Remove(NumberTextBox.Text.Length - 1);
                }
                if (e.KeyChar == '=' || e.KeyChar == '\r' /*(char)Keys.Enter*/)
                {
                    EqualButton_Click(EqualButton, e);
                }
            }
        
            private void BackSpaceButton_Click(object sender, EventArgs e)
            {
            //double few = Double.Parse(NumberTextBox.Text);
            //if (few.Equals(Double.NaN)|| NumberTextBox.Text.Length == 1 || Math.Abs(few)<10) NumberTextBox.Text = "0";
            if (NumberTextBox.Text.Length != 1) NumberTextBox.Text = NumberTextBox.Text.Remove(NumberTextBox.Text.Length - 1);
            else NumberTextBox.Text = "0";
            }

            private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            double few = Double.Parse(NumberTextBox.Text);
            if (!few.Equals(Double.NaN) && NumberTextBox.Text != "0") if (NumberTextBox.Text[0] == '-') NumberTextBox.Text = NumberTextBox.Text.Remove(0, 1);
            else NumberTextBox.Text = "-" + NumberTextBox.Text;
            }

            private void FactorialButton_Click(object sender, EventArgs e)
            {
                long s = 1;
                for (int i = 1; i <= (int)double.Parse(NumberTextBox.Text); i++) s *= i;
                NumberTextBox.Text = s.ToString();
            Op = "k";
        }

            private void OneDivXButton_Click(object sender, EventArgs e)
            {
            string result = Mathem.Function(((Button)sender).Text, NumberTextBox.Text);
            NumberTextBox.Text = result;
            Op = "k";
        }

            private void SQRTButton_Click(object sender, EventArgs e)
            {
                NumberTextBox.Text = (Math.Sqrt(double.Parse(NumberTextBox.Text))).ToString();
            Op = "k";
        }

            private void Pow2Button_Click(object sender, EventArgs e)
            {
                NumberTextBox.Text = (Math.Pow(double.Parse(NumberTextBox.Text), 2)).ToString();
            Op = "k";
        }

            private void SinButton_Click(object sender, EventArgs e)
            {
                NumberTextBox.Text = (Math.Sin(double.Parse(NumberTextBox.Text))).ToString();
            Op = "k";
        }

            private void CosButton_Click(object sender, EventArgs e)
            {
                NumberTextBox.Text = (Math.Cos(double.Parse(NumberTextBox.Text))).ToString();
            Op = "k";
        }

            private void TanButton_Click(object sender, EventArgs e)
            {
                NumberTextBox.Text = (Math.Tan(double.Parse(NumberTextBox.Text))).ToString();
            Op = "k";
        }

            private void EButton_Click(object sender, EventArgs e)
            {
                NumberTextBox.Text = Math.E.ToString();
            Op = "k";
        }

            private void PiButton_Click(object sender, EventArgs e)
            {
                NumberTextBox.Text = Math.PI.ToString();
            Op = "k";
        }

            private void OnButton(int ss)
            {
                bool a, b, c, d, e;
                a = true;
                b = true;
                c = true;
        
        d = true;
                e = true;

                if (ss==2) { a = false; b = false; c = false; d = false; }
                if (ss==8) { a = false; c = false; d = false; e = false; }
                if (ss==16) { a = false; e = false; }
                if (ss==10) { e = false; d = false; }
                AddButton.Enabled = a;
                SubtractButton.Enabled = a;
                MultiplyButton.Enabled = a;
                DivButton.Enabled = a;
                PointButton.Enabled = a;
                PlusMinusButton.Enabled = a;
                //BackSpaceButton.Enabled = a;
                FactorialButton.Enabled = a;
                OneDivXButton.Enabled = a;
                SQRTButton.Enabled = a;
                Pow2Button.Enabled = a;
                PowButton.Enabled = a;
                SinButton.Enabled = a;
                CosButton.Enabled = a;
                TanButton.Enabled = a;
                EButton.Enabled = a;
                EYButton.Enabled = a;
                PiButton.Enabled = a;
                TwoButton.Enabled = b;
                ThreeButton.Enabled = b;
                FourButton.Enabled = b;
                FiveButton.Enabled = b;
                SixButton.Enabled = b;
                SevenButton.Enabled = b;
                EightButton.Enabled = c;
                NineButton.Enabled = c;
                LiterA.Enabled = d;
                LiterB.Enabled = d;
                LiterC.Enabled = d;
                LiterD.Enabled = d;
                LiterE.Enabled = d;
                LiterF.Enabled = d;
                OrButton.Enabled = e;
                AndButton.Enabled = e;
                no.Enabled = e;

            }

            private void SS8_CheckedChanged(object sender, EventArgs e)
            {
               Op = "k";
            opr1 = new CalcSystem(NumberTextBox.Text, PreSyst);
            if (SS8.Checked)
            {
                NumberTextBox.Text = opr1.Oct;
                PreSyst = SS.Oct;
            }
            OnButton(8);
            }

            private void SS2_CheckedChanged(object sender, EventArgs e)
            {
            //Op = "k";
            //NumberTextBox.Text = SS(NumberTextBox.Text, ss, 2);
            //    ss = 2;
            OnButton(2);
            Op = "k";
            opr1 = new CalcSystem(NumberTextBox.Text, PreSyst);
            if (SS2.Checked)
            {
                NumberTextBox.Text = opr1.Bin;
                PreSyst = SS.Bin;
            }
        }

            private void SS10_CheckedChanged(object sender, EventArgs e)
            {
            Op = "k";
            //NumberTextBox.Text = SS(NumberTextBox.Text, ss, 10);
            //    ss = 10;
                OnButton(10);
            Op = "k";
            opr1 = new CalcSystem(NumberTextBox.Text, PreSyst);
            if (SS10.Checked)
            {
                NumberTextBox.Text = opr1.Dec;
                PreSyst = SS.Dec;
            }
        }

            private void SS16_CheckedChanged(object sender, EventArgs e)
            {
            //NumberTextBox.Text = SS(NumberTextBox.Text, ss, 16);
            //    ss = 16;
                OnButton(16);
            Op = "k";
            opr1 = new CalcSystem(NumberTextBox.Text, PreSyst);
            if (SS16.Checked)
            {
                NumberTextBox.Text = opr1.Hex;
                PreSyst = SS.Hex;
            }
        }

            private void OrButton_Click(object sender, EventArgs e)
            {

                //сохраняем значение числа в переменной operand1
                operand1_ = NumberTextBox.Text;
                //обнуляем содержимое окна ввода
                NumberTextBox.Text = "0";
                //сохраняем значение арифметической операции
                //в переменной Op
                Op = (sender as Button).Text;

            }

            private void no_Click(object sender, EventArgs e)
            {

                NumberTextBox.Text = No(NumberTextBox.Text);
            }

            static string No(string s)
            {
                string s2 = "";
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '0') s2 += "1";
                    else s2 += "0";
                }
            int g = 0;
            if (s2.Length !=1) while (s2[g] == '0' && g!=s2.Length-1) g++;
            s2 = s2.Remove(0, g);
            return s2;
            }
        }
    }

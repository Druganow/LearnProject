using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Mathem
    {
        public static string Function(string function, string arg)
        {
            switch (function)
            {
                case "1/x":
                    return (1 / double.Parse(arg)).ToString(); ;
                case "x!":
                    return Factorial(arg);
                case "±":
                    return Plusminus(arg);
                case "no":
                    return Not(arg);
                case "√":
                    return (Math.Sqrt(double.Parse(arg))).ToString();
                case "^2":
                    return Math.Pow(double.Parse(arg), 2).ToString();
                case "e^y":
                    return Math.Pow(Math.E, double.Parse(arg)).ToString();
                case "π":
                    return Math.PI.ToString();
                case "e":
                    return Math.E.ToString();
                case "sin":
                    return Math.Sin(double.Parse(arg)).ToString(); 
                case "cos":
                    return Math.Cos(double.Parse(arg)).ToString();
                case "tan":
                    return Math.Tan(double.Parse(arg)).ToString();
                default:
                    return null;
            }
        }

        private static string Factorial(string arg)
        {
            long s = 1;
            for (int i = 1; i <= (int)double.Parse(arg); i++) s *= i;
            return s.ToString();
        }

        private static string Plusminus(string arg)
        {
            double few = Double.Parse(arg);
            if (!few.Equals(Double.NaN) && arg != "0") if (arg[0] == '-') return arg.Remove(0, 1);
                else return "-" + arg;
            return "NaN";
        }

        private static string Not(string arg)
        {
                string s = "";
                for (int i = 0; i < arg.Length; i++)
                {
                    if (arg[i] == '0') s += "1";
                    else s += "0";
                }
                int g = 0;
                if (s.Length != 1) while (s[g] == '0' && g != s.Length - 1) g++;
                s = s.Remove(0, g);
                return s;
        }

        

    }
}


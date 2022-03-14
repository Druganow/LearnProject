using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_LINQ
{
    static class Queries
    {
        
        
        public static int[] Task1(int a, int b)
        {
            var palindromes = new List<int>();

            for (int i = a; i <= b; i++) palindromes.Add(i);
            return palindromes.Where(i => i.ToString() == new string(i.ToString().Reverse().ToArray())).ToArray();
        }

        
        public static int Task2(int a)
        {
            return a.ToString().Select(i => int.Parse(i.ToString())).Sum();
        }

        
        public static int Task3(int value, int digit)
        {
            return value.ToString().Where(i => i == char.Parse(digit.ToString())).Count();
        }

       
        public static bool Task4(int a)
        {
            if (IsSimpleNum(a)) return true;
            else return false;
        }
        
        public static int[] Task5(int a, int b)
        {
            var answer = new List<int>();
            for (int i = a; i <= b; i++) answer.Add(i);
            return answer.Where(i => IsSimpleNum(i)).ToArray();
        }
        
        public static int[] Task6(int a, int b)
        {
            var answer = new List<int>();
            var count = new List<int>();

            for (int i = a; i <= b; i++) answer.Add(i);
            foreach (var i in answer) count.Add(FindDividers(i).Count());

            return answer.Where(i => FindDividers(i).Count() == count.Max()).ToArray();
        }
        
        public static int[] Task7(int[] arr)
        {
            return arr.OrderBy(i => i).OrderBy(i => i.ToString().Last()).ToArray();
        }

        public static string Task8(string s) 
        {
            return new string(s.ToCharArray().Where(c => !char.IsDigit(c)).ToArray());
        }

        public static int Task9(int[] arr)
        {
            return arr.Distinct().Count();
        }
        
        static bool IsSimpleNum(int a)
        {
            for (int i = 2; i < a; i++)
                if (a % i == 0) return false;
            return true;
        }
        
        static int[] FindDividers(int a)
        {
            var list = new List<int>();
            for (int i = 1; i < a / 2 + 1; i++)
                if (a % i == 0) list.Add(i);
            return list.ToArray();
        }
    }
}
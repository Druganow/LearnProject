using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Задача #1. Даны 3 точки A, B и C. Определить, лежат ли они на одной прямой.

//Задача #2. Даны 3 точки A, B и C, не лежащие на одной прямой. Определить, является обход A→B→C обходом по часовой стрелке или против часовой стрелки.

//Задача #3. Даны 4 точки A, B, C и D. Определить, пересекаются ли отрезки AC и BD.

//Задача #4. Даны 4 точки A, B, C и D. Определить, является ли четырехугольник ABCD выпуклым.

//Замечания:

//а) во всех заданиях считается, что входные данные корректны;

//b) в задачах 3 и 4 если 3 или все 4 вершины оказываются на одной прямой, то четырехугольник считается выпуклым.

namespace Лаб1
{
    public struct point
    {
        public double x, y;
    }


    class Program
    {
        static bool isLine(point A, point B, point C)
        {
            return (B.x - A.x) * (C.y - A.y) - (C.x - A.x) * (B.y - A.y) == 0;
        }

        static bool isClockWise(point A, point B, point C)
        {
            return (B.x - A.x) * (C.y - A.y) - (C.x - A.x) * (B.y - A.y) < 0;
        }

        static bool isConvex4(point A, point B, point C, point D)
        {
            if (isLine(A, B, C) || isLine(A, B, D) || isLine(B, C, D)) return true;
            else if (isClockWise(A, B, C))
            {
                return isClockWise(B, C, D) && isClockWise(C, D, A) && isClockWise(D, A, B);
            }
            else return !isClockWise(B, C, D) && !isClockWise(C, D, A) && !isClockWise(D, A, B);
        }
        static string threePoint(point A, point B, point C)
        {
            double ab = Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
            double ac = Math.Sqrt(Math.Pow(A.x - C.x, 2) + Math.Pow(A.y - C.y, 2));
            double bc = Math.Sqrt(Math.Pow(C.x - B.x, 2) + Math.Pow(C.y - B.y, 2));
            if (ab > ac && ab > bc) return "C";
            else if (ac > ab && ac > bc) return "B";
            else return "A";
        }

        static point lineIntersection(point A, point B, point C, point D)
        {
            point x;
            x.x = ((A.x * B.y - A.y * B.x) * (C.x - D.x) - (A.x - B.x) * (C.x *D.y - C.y * D.x))/
                ((A.x-B.x)*(C.y-D.y)-(A.y-B.y)*(C.x-D.x));
            x.y= ((A.x * B.y- A.y * B.x) * (C.y - D.y) - (A.y - B.y) * (C.x * D.y - C.y * D.x)) /
                ((A.x - B.x) * (C.y - D.y) - (A.y - B.y) * (C.x - D.x));
            return x;
        }

        static void fun1()
        {
            point A, B, C;
            Console.WriteLine("Введите координаты точек");
            string[] s = Console.ReadLine().Split(' ');
            A.x = double.Parse(s[0]);
            A.y = double.Parse(s[1]);
            B.x = double.Parse(s[2]);
            B.y = double.Parse(s[3]);
            C.x = double.Parse(s[4]);
            C.y = double.Parse(s[5]);
            if(isLine(A,B,C)) Console.WriteLine("Лежат");
            else Console.WriteLine("Не лежат");
        }

        static void fun2()
        {
            point A, B, C;
            Console.WriteLine("Введите координаты точек");
            string[] s = Console.ReadLine().Split(' ');
            A.x = double.Parse(s[0]);
            A.y = double.Parse(s[1]);
            B.x = double.Parse(s[2]);
            B.y = double.Parse(s[3]);
            C.x = double.Parse(s[4]);
            C.y = double.Parse(s[5]);
            if (isClockWise(A, B, C)) Console.WriteLine("По часовой");
            else Console.WriteLine("Против часовой");
        }

        static void fun3()
        {
            point A, B, C, D;
            Console.WriteLine("Введите координаты точек");
            string[] s = Console.ReadLine().Split(' ');
            A.x = double.Parse(s[0]);
            A.y = double.Parse(s[1]);
            B.x = double.Parse(s[2]);
            B.y = double.Parse(s[3]);
            C.x = double.Parse(s[4]);
            C.y = double.Parse(s[5]);
            D.x = double.Parse(s[6]);

            D.y = double.Parse(s[7]);
            if (isConvex4(A, B, C, D)) Console.WriteLine("Пересекаются");
            else Console.WriteLine("Не пересекаются");
        }

        static void fun4()
        {
            point A, B, C, D;
            Console.WriteLine("Введите координаты точек");
            string[] s = Console.ReadLine().Split(' ');
            A.x = double.Parse(s[0]);
            A.y = double.Parse(s[1]);
            B.x = double.Parse(s[2]);
            B.y = double.Parse(s[3]);
            C.x = double.Parse(s[4]);
            C.y = double.Parse(s[5]);
            D.x = double.Parse(s[6]);
            D.y = double.Parse(s[7]);
            if (isConvex4(A, B, C, D)) Console.WriteLine("Выпуклый");
            else Console.WriteLine("Не выпуклый");
        }

        static void fun5()
        {
            point A, B, C;
            Console.WriteLine("Введите координаты точек");
            string[] s = Console.ReadLine().Split(' ');
            A.x = double.Parse(s[0]);
            A.y = double.Parse(s[1]);
            B.x = double.Parse(s[2]);
            B.y = double.Parse(s[3]);
            C.x = double.Parse(s[4]);
            C.y = double.Parse(s[5]);
            Console.WriteLine(threePoint(A, B, C));
        }

        static void fun6()
        {
            point A, B, C, D;
            Console.WriteLine("Введите координаты точек");
            string[] s = Console.ReadLine().Split(' ');
            A.x = double.Parse(s[0]);
            A.y = double.Parse(s[1]);
            B.x = double.Parse(s[2]);
            B.y = double.Parse(s[3]);
            s = Console.ReadLine().Split(' ');
            C.x = double.Parse(s[0]);
            C.y = double.Parse(s[1]);
            D.x = double.Parse(s[2]);
            D.y = double.Parse(s[3]);
            point answer = lineIntersection(A, B, C, D);
            Console.WriteLine(answer.x + " " + answer.y);
        }

        static void Main(string[] args)
        {
            point A, B, C, D;
            int x = 0;
            while(x==0)
            {
                Console.WriteLine("1.Определить, лежат ли 3 точки на одной прямой\n" +
                    "2.Определить, является обход A→B→C обходом по часовой стрелке или против часовой стрелки\n" +
                    "3.Определить, пересекаются ли отрезки AC и BD\n" +
                    "4.Определить, является ли четырехугольник ABCD выпуклым\n" +
                    "5.Определить, какая из 3 точек лежит между двумя другими\n" +
                    "6.Найти точку пересечения 2-ух прямых\n" +
                    "Любой другой символ - выход");
                switch(Console.ReadLine())
                {
                    case "1": fun1(); break;
                    case "2": fun2(); break;
                    case "3": fun3(); break;
                    case "4": fun4(); break;
                    case "5": fun5(); break;
                    case "6": fun6(); break;
                    default: x=1; break;
                }          
            }
        }
    }
}

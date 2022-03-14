using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    class DiffSystemOfEqual
    {
        public const int PARAMS_COUNT = 13;
        //делегат. Позволяет создать массив функций. 
        public delegate double Func();
        const double GRAV_CONST = 1;


        //константные значения
        public static double m1, m2, m3;
        //параметры уравнений
        public double t, x1, x2, x3, y1, y2, y3, vx1, vx2, vx3, vy1, vy2, vy3;
        //система уравнений в виде массива функций
        Func[] F;
        // Список всех параметров:
        //0  1  2     3  4      5  6    7   8   9  10    11  12
        //t  X1,Vx1,  Y1,Vy1,  X2,Vx2,  Y2,Vy2  X3,Vx3,  Y3,Vy3
        public DiffSystemOfEqual(double[] param)
        {
            t = param[0];
            x1 = param[1];
            vx1 = param[2];
            y1 = param[3];
            vy1 = param[4];

            x2 = param[5];
            vx2 = param[6];
            y2 = param[7];
            vy2 = param[8];

            x3 = param[9];
            vx3 = param[10];
            y3 = param[11];
            vy3 = param[12];

            F = new Func[] {
                FuncT,
                FuncX1,FuncVx1,FuncY1,FuncVy1,
                FuncX2,FuncVx2,FuncY2,FuncVy2,
                FuncX3,FuncVx3,FuncY3,FuncVy3 };
        }

        public Point[] GetCoord()
        {
            return new Point[]
            {
                new Point((int)x1,(int)y1),
                new Point((int)x2,(int)y2),
                new Point((int)x3,(int)y3)
            };
        }


        static public double r(double x1 , double x2, double y1, double y2)
        {

            double a = Math.Pow(x1 - x2, 2);
            double b = Math.Pow(y1 - y2, 2);
            double c = Math.Sqrt(a + b);
            return Math.Pow(c,3);

        }
        //Система Обыкновенных Дифф. Ур. Первого порядка. 
        double FuncX1()
        {
            return vx1;
        }
        double FuncY1()
        {
            return vy1;
        }
        double FuncX2()
        {
            return vx2;

        }
        double FuncY2()
        {
            return vy2;
        }
        double FuncX3()
        {
            return vx3;
        }
        double FuncY3()
        {
            return vy3;
        }
        double FuncVx1()
        {
            return -GRAV_CONST * (m2 * (x1 - x2) / r(x1, x2, y1, y2)
                + m3 * (x1 - x3) / r(x1, x3, y1, y3));
        }
        double FuncVy1()
        {
            return -GRAV_CONST * (m2 * (y1 - y2) / r(x1, x2, y1, y2) +
                m3 * (y1 - y3) / r(x1, x3, y1, y3));
        }
        double FuncVx2()
        {
            return -GRAV_CONST * (m1 * (x2 - x1) / r(x2, x1, y2, y1) +
                m3 * (x2 - x3) / r(x2, x3, y2, y3));
        }
        double FuncVy2()
        {
            return -GRAV_CONST * (m1 * (y2 - y1) / r(x2, x1, y2, y1) +
                m3 * (y2 - y3) / r(x2, x3, y2, y3));
        }
        double FuncVx3()
        {
            return -GRAV_CONST * (m1 * (x3 - x1) / r(x3, x1, y3, y1) +
                m2 * (x3 - x2) / r(x3, x2, y3, y2));
        }
        double FuncVy3()
        {
            return -GRAV_CONST * (m1 * (y3 - y1) / r(x3, x1, y3, y1) +
                m2 * (y3 - y2) / r(x3, x2, y3, y2));
        }
        double FuncT()
        {
            return 1;
        }
        //Расчёт следующих значений k для метода Рунге-Кутта
        public double[] GetRes(double dt)
        {
            double[] k = new double[PARAMS_COUNT];
            for (int i = 0; i < PARAMS_COUNT; i++)
            {
                k[i] = F[i]() * dt;
            }
            return k;
        }
    }
}

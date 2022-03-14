using System;

namespace MM_L2.SelfOscillatingSystem
{
    delegate double Func();

    class SoODE
    {
        public const int PARAMS_COUNT = 3;   

        //константы
        public static double a1,a2,b,b1,h,p;
        
        public readonly double  t, x, z;

        private Func[] F;

        public SoODE(double[] param)
        {
            t = param[0];
            x = param[1];
            z = param[2];
            F = new Func[] {FuncTp, FuncXp, FuncZp };
        }
     
        //0  1  2     
        //t  X  Z
         double FuncTp()
        {
            return 1;
        }

         double FuncXp()
        {
            return z;
        }

         double FuncZp()
        {
            return h * Math.Sin(p * t) - (a1 * x + a2 * x * x) + z * (b - b1 * x * x);
        }

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

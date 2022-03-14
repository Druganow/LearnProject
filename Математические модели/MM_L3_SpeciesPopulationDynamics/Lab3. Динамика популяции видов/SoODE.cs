namespace Lab3.Динамика_популяции_видов
{
    delegate double Func();
    class SoODE
    {


        public const int PARAMS_COUNT = 3;
        

        //константы
        public static double a1,a2,b12,b21,c1,c2;
        
        public readonly double  t, x1, x2;

        private Func[] F;
        public SoODE(double[] param)
        {
            t = param[0];
            x1 = param[1];
            x2 = param[2];
            F = new Func[] {
                FuncTp, FuncX1p, FuncX2p };
        }
        double[] SoODEtoArr() => new double[]
            {
                t, x1,x2
            };

        //0  1  2     
        //t  X1  X2
        double FuncTp()
        {
            return 1;
        }
         double FuncX1p()
        {
            return a1 * x1 + b12 * x1 * x2 - c1 * x1 * x1;
        }
         double FuncX2p()
        {
            return a2 * x2 + b21 * x1 * x2 - c2 * x2 * x2;
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

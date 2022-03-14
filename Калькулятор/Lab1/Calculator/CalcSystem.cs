using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    public enum SS { Bin, Dec, Oct, Hex };

    public class CalcSystem
	{
		private double number;

		public string Bin { get; set; }
		public string Dec { get; set; }
		public string Oct { get; set; }
		public string Hex { get; set; }

		public CalcSystem(string num, SS numSystem)
		{
			if (numSystem == SS.Hex)
			{
				Hex = num;
				Bin = Convert.ToString((int)double.Parse(Convert.ToInt64(Hex, 16).ToString()), 2);
				Dec = Convert.ToInt32(Hex, 16).ToString();
				Oct = Convert.ToString((int)Convert.ToInt32(Hex, 16), 8);
			}
			else
			{
				number = double.Parse(num);
				if (numSystem == SS.Bin)
				{
					Bin = number.ToString();
					Dec = Convert.ToInt32(number.ToString(), 2).ToString();
					Oct = Convert.ToString((int)Convert.ToInt32(Bin, 2), 8);
					Hex = Convert.ToString((int)Convert.ToInt32(Bin, 2), 16);
				}
				if (numSystem == SS.Dec)
				{
					Dec = number.ToString();
					Bin = Convert.ToString((int)number, 2);
					Oct = Convert.ToString((int)number, 8);
					Hex = Convert.ToString((int)number, 16);
				}
				if (numSystem == SS.Oct)
				{
					Oct = number.ToString();
					Bin = Convert.ToString((int)Convert.ToInt32(Oct, 8), 2);
					Dec = Convert.ToInt32(number.ToString(), 8).ToString();
					Hex = Convert.ToString((int)Convert.ToInt32(Oct, 8), 16);
				}
			}
		}

		public static CalcSystem operator &(CalcSystem opr1, CalcSystem opr2)
		{
			int dec1 = Convert.ToInt32(opr1.Bin, 2);
			int dec2 = Convert.ToInt32(opr2.Bin, 2);
			return new CalcSystem(Convert.ToString(dec1 & dec2, 2), SS.Bin);
		}

		public static CalcSystem operator |(CalcSystem opr1, CalcSystem opr2)
		{
			int dec1 = Convert.ToInt32(opr1.Bin, 2);
			int dec2 = Convert.ToInt32(opr2.Bin, 2);
			return new CalcSystem(Convert.ToString(dec1 | dec2, 2), SS.Bin);
		}

		public override string ToString()
		{
			return Dec;
		}
     

        public static CalcSystem operator +(CalcSystem opr1, CalcSystem opr2)
        {
            return new CalcSystem((double.Parse(opr1.Dec) + double.Parse(opr2.Dec)).ToString(),
                SS.Dec);
        }

        public static implicit operator double(CalcSystem num)
        {
            return double.Parse(num.Dec);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab5
{
    public class GPoint : GFigure
    {
        
        public GPoint(Graphics _Field) : base(_Field)
        { }

        public int X {get; set;}

        public int Y{ get; set;}

        public override void Draw()
        {
            Field.FillRectangle(new SolidBrush(GColor), X, Y, 1, 1);
           
        }
        
             public  void Draw(Color col, float W)
        {
            Field.FillRectangle(new SolidBrush(col), X - W / 2, Y - W / 2, W, W);

        }
    }
}
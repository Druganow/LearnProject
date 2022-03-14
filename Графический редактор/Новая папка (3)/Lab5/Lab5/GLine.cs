using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab5
{
    public class GLine : GFigure
    {
        public Point LineBeg { get; set; }
        public Point LineEnd { get; set; }

        public GLine(Graphics _Field): base(_Field)
        { }
        public override void Draw()
        {
            Field.DrawLine(new Pen(GColor), LineBeg, LineEnd);
        }
        public void Draw(Color col, float W)
        {
            Field.DrawLine(new Pen(col,W), LineBeg, LineEnd);
        }
    }
}
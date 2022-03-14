using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5
{
    class GEllips : GFigure
    {
        public Point Corner1 { get; set; }//верх левый
        public Point Corner2 { get; set; }//низ правый

        public GEllips(Graphics G) : base(G)
        { }
        public override void Draw()
        {
            float x = Math.Min(Corner1.X, Corner2.X);
            float y = Math.Min(Corner1.Y, Corner2.Y);
            float width = Math.Abs(Corner2.X - Corner1.X);
            float height = Math.Abs(Corner2.Y - Corner1.Y);
            Field.DrawEllipse(new Pen(GColor), x, y, width, height);
        }
        public new void Draw(Color col)
        {
            float x = Math.Min(Corner1.X, Corner2.X);
            float y = Math.Min(Corner1.Y, Corner2.Y);
            float width = Math.Abs(Corner2.X - Corner1.X);
            float height = Math.Abs(Corner2.Y - Corner1.Y);
            Field.FillEllipse(new SolidBrush(col), x, y, width, height);
        }
        public new void Draw(Color col1, Color col2, float W)
        {
            GColor = col1;
            float x = Math.Min(Corner1.X, Corner2.X);
            float y = Math.Min(Corner1.Y, Corner2.Y);
            float width = Math.Abs(Corner2.X - Corner1.X);
            float height = Math.Abs(Corner2.Y - Corner1.Y);
            Field.DrawEllipse(new Pen(GColor,W), x, y, width, height);
            Field.FillEllipse(new SolidBrush(col2), x, y, width, height);

        }
    }
}

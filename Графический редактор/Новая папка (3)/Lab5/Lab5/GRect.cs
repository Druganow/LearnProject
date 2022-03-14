using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab5
{
    public class GRect : GFigure
    {
        public Point Corner1 { get; set; }//верх левый
        public Point Corner2 { get; set; }//низ правый

        public GRect(Graphics G):base(G)
        {  }

        public override void Draw()
        {
            float x = Math.Min(Corner1.X, Corner2.X);
            float y = Math.Min(Corner1.Y, Corner2.Y);
            float width = Math.Abs(Corner2.X - Corner1.X);
            float height = Math.Abs(Corner2.Y - Corner1.Y);
            Field.DrawRectangle(new Pen(GColor), x, y, width%x, height%y);
        }
        public void Draw(Color col)
        {
            GColor = col;
            float x = Math.Min(Corner1.X, Corner2.X);
            float y = Math.Min(Corner1.Y, Corner2.Y);
            float width = Math.Abs(Corner2.X - Corner1.X);
            float height = Math.Abs(Corner2.Y - Corner1.Y);
            Field.FillRectangle(new SolidBrush(GColor), x, y, width, height);
        }
        public void Draw(Color col1, Color col2, float W)
        {
            GColor = col1;
            GBackColor = col2;
           // float k = (float)Math.Sqrt(Math.Abs(Corner1.X - Corner2.X) * Math.Abs(Corner1.X - Corner2.X) + Math.Abs(Corner1.Y - Corner2.Y) * Math.Abs(Corner1.Y - Corner2.Y));
            float x = Math.Min(Corner1.X, Corner2.X);
            float y = Math.Min(Corner1.Y, Corner2.Y);
            float width = Math.Abs(Corner2.X - Corner1.X);
            float height = Math.Abs(Corner2.Y - Corner1.Y);
            Field.DrawRectangle(new Pen(GColor,W), x, y, width, height);
            Field.FillRectangle(new SolidBrush(GBackColor), x, y, width, height);
            

        }
    }
}
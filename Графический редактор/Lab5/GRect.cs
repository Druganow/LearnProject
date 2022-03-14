using System.Drawing;
using System;
namespace Lab5
{
    public class GRect : GFigure
    {
        public GRect(Graphics _Field)
        {
            Field = _Field;
        }

        public Point Corner1
        {
            get; set;
        }

        public Point Corner2
        {
            get; set;
        }

        public override void Draw()
        {
            float x = Math.Min(Corner1.X, Corner2.X);
            float y = Math.Min(Corner1.Y, Corner2.Y);
            float width = Math.Abs(Corner2.X - Corner1.X);
            float height = Math.Abs(Corner2.Y - Corner1.Y);
            Field.DrawRectangle(new Pen(gColor), x, y, width % x, height % y);
        }
        public void Draw(Color col)
        {
            gColor = col;
            float x = Math.Min(Corner1.X, Corner2.X);
            float y = Math.Min(Corner1.Y, Corner2.Y);
            float width = Math.Abs(Corner2.X - Corner1.X);
            float height = Math.Abs(Corner2.Y - Corner1.Y);
            Field.FillRectangle(new SolidBrush(gColor), x, y, width, height);
        }

        public void Draw(Color col, float W)
        {
            gColor = col;
            float x = Math.Min(Corner1.X, Corner2.X);
            float y = Math.Min(Corner1.Y, Corner2.Y);
            float width = Math.Abs(Corner2.X - Corner1.X);
            float height = Math.Abs(Corner2.Y - Corner1.Y);
            Field.DrawRectangle(new Pen(gColor, W), x, y, width, height);
        }
        public void Draw(Color col1, Color col2, float W)
        {
            gColor = col1;
            gColorBack = col2;
            float x = Math.Min(Corner1.X, Corner2.X);
            float y = Math.Min(Corner1.Y, Corner2.Y);
            float width = Math.Abs(Corner2.X - Corner1.X);
            float height = Math.Abs(Corner2.Y - Corner1.Y);
            Field.DrawRectangle(new Pen(gColor, W), x, y, width, height);
            Field.FillRectangle(new SolidBrush(gColorBack), x, y, width, height);
        }
    }
}
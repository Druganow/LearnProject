using System.Drawing;
namespace Lab5
{
    public class GLine : GFigure
    {
        public GLine(Graphics _Field)
        {
            Field = _Field;
        }

        public Point LineBeg
        {
            get; set;
        }

        public Point LineEnd
        {
            get; set;
        }

        public override void Draw()
        {
            Field.DrawLine(new Pen(gColor), LineBeg, LineEnd);
        }

        public void Draw(Color col, float W)
        {
            Field.DrawLine(new Pen(col, W), LineBeg, LineEnd);
        }
    }
}
using System.Drawing;
namespace Lab5
{
    public abstract class GFigure
{
    protected Graphics Field;
    protected Color gColor = Color.Black;
        protected System.Drawing.Color gColorBack;

        protected GFigure()
    {
    }
    protected GFigure(Graphics _Field)
    {
        Field = _Field;
    }
    public abstract void Draw();
}
}


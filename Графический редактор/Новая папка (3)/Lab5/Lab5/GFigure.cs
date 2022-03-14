using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab5
{
    public abstract class GFigure
    {
        protected Color GColor = Color.Black;
        protected Color GBackColor = Color.White;
        protected Graphics Field;

        public GFigure()
        {
        }

        public GFigure(Graphics _Field)
        {
            Field = _Field;
        }

        public abstract void Draw();
    }
}
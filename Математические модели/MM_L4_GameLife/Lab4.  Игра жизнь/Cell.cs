using System.Drawing;
using System.Windows.Forms;

namespace Lab4.GameLife
{
    class Cell: Panel
    {
        // все клетки
        public static Cell[,] Cells;
        //красный - живая клетка
        public static Color LifeColor = Color.Purple;
        public static Color DeathColor = Color.White;

        public bool ItsAlive { get; private set; }

        public readonly int x;
        public readonly int y;

        public Cell(int X, int Y, int width, Panel parent)
        {
            x = X + 1;
            y = Y + 1;
            Parent = parent;
            Width = Height = width;
            Location = new Point(X * width + X, Y * width + Y);
            Die();
            Cells[x, y] = this;
        }

        //Рождение клетки/перекрасить в цвет жизни
        public void Born()
        {
            ItsAlive = true;
            BackColor = LifeColor;
        }

        //смерть / вернуть цвет фона
        public void Die()
        {
            ItsAlive = false;
            BackColor = DeathColor;
        }

        //проверка выживет ли клетка к следующему шагу или нет
        public bool Survive()
        {
            //количество живых соседних клеток
            int lifeCount = Check(x - 1, y + 1) + Check(x, y + 1) + 
                            Check(x + 1, y + 1) + Check(x - 1, y) +
                            Check(x + 1, y) + Check(x - 1, y - 1) + 
                            Check(x, y - 1) + Check(x + 1, y - 1);
            
            /*
            // ИСХОДНЫЕ ПРАВИЛА
            //Рождение:
            if (!ItsAlive && lifeCount == 3) return true;
            // Выживание:
            if (ItsAlive && lifeCount >= 2 && lifeCount <= 3) return true;
            //Гибель
            else return false;
            */

            
            // КАСТОМНЫЕ ПРАВИЛА
            //Рождение:
            if (!ItsAlive && lifeCount == 2) return true;
            // Выживание:
            if (ItsAlive && lifeCount >= 1 && lifeCount <= 2) return true;
            //Гибель
            else return  false;
            
        }

        //проверка клетки по индексу живая или не живая
        public static int Check(int x, int y)
        {
            if (Cells[x, y] == null) return 0;
            return Cells[x, y].ItsAlive? 1: 0;
        }
    }
}

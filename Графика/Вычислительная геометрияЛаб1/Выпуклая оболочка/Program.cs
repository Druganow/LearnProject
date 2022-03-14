using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Выпуклая_оболочка
{
    public class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Program
    {
        public static int isClockWise(Point p, Point q, Point r)
        {
            int val = (q.y - p.y) * (r.x - q.x) - (q.x - p.x) * (r.y - q.y);

            if (val == 0) return 0;
            return (val > 0) ? 1 : 2; // по или против часовой стрелки 
        }

       
        public static void convex(Point[] points, int n)
        {
            if (n < 3) return;
            List<Point> hull = new List<Point>();
            int l = 0;
            for (int i = 1; i < n; i++)
                if (points[i].x < points[l].x) l = i;
            int p = l, q;
            do
            {
                hull.Add(points[p]);
                q = (p + 1) % n;
                for (int i = 0; i < n; i++)
                {
                    if (isClockWise(points[p], points[i], points[q])== 2) q = i;
                }
                p = q;

            } while (p != l); 
            foreach (Point t in hull) Console.WriteLine(t.x + ", " + t.y);
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Введите количество точек");
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                points[i] = new Point(int.Parse(s[0]), int.Parse(s[1]));
            }
            convex(points, n);
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4
{
    internal class Point
    {
        private float x, y;
        Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public void SetX(float x)
        {
            this.x = x;
        }
        public float GetX()
        {
            return this.x;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public float GetY()
        {
            return this.y;
        }
        public int Distance(Point a, Point b)
        {

            int distance;
            a = new Point(x, y);
            b = new Point(x, y);
            distance = (int)Math.Sqrt(Math.Pow(a.x - b.x, 2) - Math.Pow(a.y - b.y, 2));
            return distance;

        }
        public bool Egalite(Point p)
        {
            if (p.x == this.x && p.y == this.y)
            {
                return true;
            }
            return false;
        }
        public void Translation(int k)
        {
            SetX(k * this.x);
            SetY(k * this.y);
        }
    }
}
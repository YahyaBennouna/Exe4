using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3;

namespace exe4
{
    internal class Droite
    {
        private Point p1;
        private Point p2;

        public Droite(Point p1, Point p2)
        {
            this.p1 = new Point(p1.GetX(), p1.GetY());
            this.p2 = new Point(p2.GetX(), p2.GetY());
        }
        public void setP1(float x, float y)
        {
            p1.SetX(x);
            p1.SetX(y);
        }
        public void setP2(float x, float y)
        {
            p2.SetX(x);
            p2.SetX(y);
        }
        public Point GetP1()
        {
            return p1;
        }
        public Point GetP2()
        {
            return p2;
        }
        public bool Collineaire(Droite d)
        {
            if (Point.lineaire(this.p1, this.p2, d.p1) && Point.lineaire(this.p1, this.p2, d.p2))
            {
                return true;
            }
            return false;
        }
        public bool Parallele(Droite d)
        {
            float a1 = (this.p1.GetY() - this.p2.GetY()) / (this.p1.GetX() - this.p2.GetX());
            float b1 = this.p1.GetY() - a1 * this.p1.GetX();
            float a2 = (d.p1.GetY() - d.p2.GetY()) / (d.p1.GetX() - d.p2.GetX());
            float b2 = d.p1.GetY() - a2 * d.p1.GetX();
            if ((a1 * b2 - a2 * b1) == 0)
            {
                return true;
            }
            return false;
        }
        public bool Intersection(Droite d)
        {
            return !Parallele(d);
        }
    }
}
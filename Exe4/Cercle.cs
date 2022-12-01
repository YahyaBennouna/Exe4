using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exe4;

namespace exe4
{
    internal class Cercle
    {
        private Point center;
        private float n;
        public Cercle(Point center, float n)
        {
            this.center = new Point(center.GetX(), center.GetY());
            this.n = n;
        }
        public Cercle(float x1, float y1, float n)
        {
            this.center = new Point(x1, y1);
            this.n = n;
        }
        //setters and getters
        public void setCenter(Point p)
        {
            this.center.SetX(p.GetX());
            this.center.SetY(p.GetY());
        }
        public void setR(float n)
        {
            this.n = n;
        }
        public Point getCenter()
        {
            return this.center;
        }
        public float getR()
        {
            return this.n;
        }
    }
}
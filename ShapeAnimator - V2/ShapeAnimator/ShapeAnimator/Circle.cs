using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShapeAnimator
{
    class Circle
    {
        public Point Center = new Point();
        public int Radius;

        public int delta = 1; // -10 to go left, +10 to go right

        public Circle(Point p, int r)
        {
            Center = p;
            Radius = r;
        }
    }
}

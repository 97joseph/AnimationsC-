using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShapeAnimator
{
    class ShapeAnimationEngine
    {
        public List<Circle> circles = new List<Circle>();

        internal void AddCircle(Point p, int r)
        {
            Circle c = new Circle(p, r);
            circles.Add(c);
        }
    }
}

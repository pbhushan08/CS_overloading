using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Circle: Shapes
    {
        public double radius;

        public Circle(double radius,int edges) : base(edges)
        {
            this.radius = radius;
        }
    }
}

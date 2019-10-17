using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle: Shapes
    {
        public double length;
        public double breadth;
        public Rectangle(double length, double breadth,int edges) : base(edges)
        {
            this.length = length;
            this.breadth = breadth;
            
        }
    }
}

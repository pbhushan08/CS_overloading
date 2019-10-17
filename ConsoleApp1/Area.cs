using System;

namespace ConsoleApp1
{
    class Area
    {
        public double area(Circle circle)
        {
            return 3.141 * circle.radius * circle.radius;
        }

        public double area(Rectangle rectangle)
        {
            return rectangle.breadth * rectangle.length;
        }

        public static void Main(string[] args)
        {
            Circle circle = new Circle(12.0);
            Rectangle rectangle = new Rectangle(12.0, 15.12);

            Area ar = new Area();
            Console.WriteLine(ar.area(circle));
            Console.WriteLine(ar.area(rectangle));
        }
    }
}

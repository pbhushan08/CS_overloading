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
            Console.WriteLine("Enter the radius of the circle\n");
            double rad = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the dimension of the Rectangle\n");
            double length = Double.Parse(Console.ReadLine());
            double breadth = Double.Parse(Console.ReadLine());
            Circle circle = new Circle(rad, 0);
            Rectangle rectangle = new Rectangle(length,breadth,4);

            Area ar = new Area();
            Console.WriteLine("Area of the Circle is {0}",ar.area(circle));
            Console.WriteLine("Area of the Rectangle is {0}", ar.area(rectangle));

            Console.WriteLine("No of edges on a Circle is {0}", circle.edges);
            Console.WriteLine("No of edges on a Rectangle is {0}", rectangle.edges);


        }
    }
}

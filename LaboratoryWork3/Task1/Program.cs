using System;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4.0, 7.0);
            Console.WriteLine("Area of rectangle:");
            Console.WriteLine(rectangle.AreaCalculator());
            Console.WriteLine("Perimeter of rectangle:");
            Console.WriteLine(rectangle.PerimeterCalculator());
        }
    }
}
using System;
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(4, 4, "S");
            Point point2 = new Point(6, 7, "Q");
            Point point3 = new Point(10, 5, "R");
            Point point4 = new Point(8, 2, "T");
            Point point5 = new Point(8, 6, "K");
            Figure triangle = new Figure(point1, point2, point3);
            triangle.PerimeterCalculator();
            Figure quadrangle = new Figure(point1, point2, point3,point4);
            quadrangle.PerimeterCalculator();
            Figure pentagon = new Figure(point1, point2, point3, point4,point5);
            pentagon.PerimeterCalculator();
        }
    }
}
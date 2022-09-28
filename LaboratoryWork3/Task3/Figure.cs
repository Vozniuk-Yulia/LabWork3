using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Figure
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;
        private Point e;
        private double perimeter;
        private string typeOfPolyhedron;
        public Figure(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            typeOfPolyhedron = "triangle";
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            this.a=a;
            this.b=b;
            this.c=c;
            this.d=d;
            typeOfPolyhedron = "quadrangle";
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            typeOfPolyhedron = "pentagon";
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y-B.Y,2));
        }
        public void PerimeterCalculator()
        {
            switch(typeOfPolyhedron)
            {
                case "triangle":
                    perimeter=LengthSide(a, b)+LengthSide(b,c)+LengthSide(a,c);
                    Console.WriteLine($"The perimeter of the triangle: {perimeter}");
                    break;
                case "quadrangle":
                    perimeter=LengthSide(a,b)+LengthSide(b,c)+LengthSide(c,d)+LengthSide(a,d);
                    Console.WriteLine($"The perimeter of the quadrangle: {perimeter}");
                    break;
                case "pentagon":
                    perimeter=LengthSide(a,b)+LengthSide(b,c)+LengthSide(c,d)+LengthSide(d,e)+LengthSide(a,e);
                    Console.WriteLine($"The perimeter of the pentagon: {perimeter}");
                    break;
                default:
                    Console.WriteLine("Wrong");
                    break;
            }
        }
    }
}

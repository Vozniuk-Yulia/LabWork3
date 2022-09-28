using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Rectangle
    {
        private double side1;
        private double side2;
        private double area;
        private double perimeter;
        public double Area
        {
            get { return area; }
        }
        public double Perimeter
        {
            get { return perimeter; }
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            area = side1 * side2;
            return area;
        }
        public double PerimeterCalculator()
        {
            perimeter = 2.0 * side1 + 2.0 * side2;
            return perimeter;
        }
    }
}

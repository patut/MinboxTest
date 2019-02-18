using MinboxTest.SquareLibrary.Operations;
using System;

namespace MinboxTest.SquareLibrary.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0)
                throw new ArgumentException("Side 1 should be more than 0");

            if (side2 <= 0)
                throw new ArgumentException("Side 2 should be more than 0");

            if (side3 <= 0)
                throw new ArgumentException("Side 3 should be more than 0");

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double Side1 { get; set; }

        public double Side2 { get; set; }

        public double Side3 { get; set; }
    }
}

using MinboxTest.SquareLibrary.Operations;
using System;

namespace MinboxTest.SquareLibrary.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius should be more than 0.");

            Radius = radius;
        }
    }
}

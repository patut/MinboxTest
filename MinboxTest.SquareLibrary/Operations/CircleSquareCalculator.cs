using MinboxTest.SquareLibrary.Shapes;
using System;

namespace MinboxTest.SquareLibrary.Operations
{
    public class CircleSquareCalculator : ISquareCalculator<Circle>
    {
        public CircleSquareCalculator()
        {
        }

        public double CalculateSquare(Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }
    }
}

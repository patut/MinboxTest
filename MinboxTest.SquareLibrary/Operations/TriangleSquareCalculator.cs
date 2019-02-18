using MinboxTest.SquareLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinboxTest.SquareLibrary.Operations
{
    public class TriangleSquareCalculator : ISquareCalculator<Triangle>
    {
        public double CalculateSquare(Triangle triangle)
        {
            var half = (triangle.Side1 + triangle.Side2 + triangle.Side3) / 2;

            var res = half * (half - triangle.Side1) * (half - triangle.Side2) * (half - triangle.Side3);

            return Math.Sqrt(res);
        }

        public bool IsSquare(Triangle triangle)
        {
            var sides = new List<double>() { triangle.Side1, triangle.Side2, triangle.Side3 };
            var max = sides.Max();

            var otherSides = sides.Where(s => s != max);

            var sum1 = otherSides.Sum(s => Math.Pow(s, 2));
            var sum2 = Math.Pow(max, 2);

            return sum1 == sum2;
        }
    }
}

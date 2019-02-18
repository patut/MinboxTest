using MinboxTest.SquareLibrary.Operations;
using MinboxTest.SquareLibrary.Shapes;

namespace MinboxTest.SquareLibrary
{
    public static partial class SquareFactory
    {
        public static double GetSquare(Circle shape)
        {
            var calculator = new CircleSquareCalculator();
            return calculator.CalculateSquare(shape);
        }

        public static double GetSquare(Triangle shape)
        {
            var calculator = new TriangleSquareCalculator();
            return calculator.CalculateSquare(shape);
        }
    }
}

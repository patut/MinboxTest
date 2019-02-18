using MinboxTest.SquareLibrary.Shapes;

namespace MinboxTest.SquareLibrary.Operations
{
    public interface ISquareCalculator<T> where T : Shape
    {
        double CalculateSquare(T shape);
    }
}

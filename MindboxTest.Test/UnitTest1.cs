using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinboxTest.SquareLibrary;
using MinboxTest.SquareLibrary.Operations;
using MinboxTest.SquareLibrary.Shapes;
using System;

namespace MindboxTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircleSquare()
        {
            var circle = new Circle(2);
            var square = SquareFactory.GetSquare(circle);

            Assert.AreEqual(4 * Math.PI, square);
        }

        [TestMethod]
        public void TestTriangleSquare()
        {
            var triangle = new Triangle(3, 4, 5);
            var square = SquareFactory.GetSquare(triangle);

            Assert.AreEqual(6, square);
        }

        [TestMethod]
        public void TriangleIsSquare()
        {
            var calculator = new TriangleSquareCalculator();

            var triangle = new Triangle(3, 4, 5);
            var result1 = calculator.IsSquare(triangle);

            Assert.AreEqual(true, result1);

            var triangle2 = new Triangle(3, 4, 6);
            var result2 = calculator.IsSquare(triangle2);

            Assert.AreEqual(false, result2);
        }
    }
}

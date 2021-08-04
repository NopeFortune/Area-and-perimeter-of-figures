using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTests
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void CirclePerimeterTest()
        {
            // Arrange
            double A = 2;
            double expected = 8;

            // Act
            Square square = new Square(A);
            double actual = square.Perimeter();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareAreaTest()
        {
            // Arrange
            double A = 2;
            double expected = 4;

            // Act
            Square square = new Square(A);
            double actual = square.Area();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

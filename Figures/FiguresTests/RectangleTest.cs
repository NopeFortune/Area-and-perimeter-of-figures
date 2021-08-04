using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTests
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void RectanglePerimeterTest()
        {
            // Arrange
            double A = 2;
            double B = 3;
            double expected = 10;

            // Act
            Rectangle rectangle = new Rectangle(A, B);
            double actual = rectangle.Perimeter();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RectangleAreaTest()
        {
            // Arrange
            double A = 2;
            double B = 3;
            double expected = 6;

            // Act
            Rectangle rectangle = new Rectangle(A, B);
            double actual = rectangle.Area();
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

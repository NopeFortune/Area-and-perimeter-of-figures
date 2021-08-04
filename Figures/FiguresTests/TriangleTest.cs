using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TrianglePerimeterTest()
        {
            // Arrange
            double A = 2;
            double B = 4;
            double C = 6;
            double H = 3;
            double expected = 12;

            // Act
            Triangle triangle = new Triangle(A, B, C, H);
            double actual = triangle.Perimeter();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TriangleAreaTest()
        {
            // Arrange
            double A = 2;
            double B = 4;
            double C = 6;
            double H = 3;
            double expected = 6;

            // Act
            Triangle triangle = new Triangle(A, B, C, H);
            double actual = triangle.Area();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

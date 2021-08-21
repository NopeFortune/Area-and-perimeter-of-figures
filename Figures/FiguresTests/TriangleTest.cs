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
            double B = 2;
            double C = 2;
            double H = 3;
            double expected = 6;

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
            double B = 2;
            double C = 2;
            double H = 2;
            double expected = 2;

            // Act
            Triangle triangle = new Triangle(A, B, C, H);
            double actual = triangle.Area();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(TriangleException))]
        public void TriangleZeroSideTestMethod()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double h = 0;

            try
            {
                Triangle triangle = new Triangle(a, b, c, h);
            }
            catch(TriangleException)
            {
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(TriangleException))]
        public void TriangleOneSideBiggerThanSumOfTwoOtherSidesTestMethod()
        {
            double a = 4;
            double b = 2;
            double c = 2;
            double h = 1;

            try
            {
                Triangle triangle = new Triangle(a, b, c, h);
            }
            catch(TriangleException)
            {
                throw;
            }
        }
    }
}

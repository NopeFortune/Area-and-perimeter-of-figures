using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTests
{
    [TestClass]
    public class TrapezoidTest
    {
        [TestMethod]
        public void TrapezoidPerimeterTest()
        {
            // Arrange
            double A = 1;
            double B = 2;
            double C = 3;
            double D = 4;
            double H = 3;
            double expected = 10;

            // Act
            Trapezoid trapezoid = new Trapezoid(A, B, C, D, H);
            double actual = trapezoid.Perimeter();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TrapezoidArea()
        {
            // Arrange
            double A = 1;
            double B = 2;
            double C = 3;
            double D = 4;
            double H = 3;
            double expected = 4.5;

            // Act
            Trapezoid trapezoid = new Trapezoid(A, B, C, D, H);
            double actual = trapezoid.Area();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

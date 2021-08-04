using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTests
{
    [TestClass]
    public class RhombTest
    {
        [TestMethod]
        public void RhombPerimeterTest()
        {
            // Arrange
            double A = 2;
            double H = 3;
            double expected = 6;

            // Act
            Rhomb rhomb = new Rhomb(A, H);
            double actual = rhomb.Perimeter();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RhombAreaTest()
        {
            // Arrange
            double A = 2;
            double H = 0;
            double expected = 8;

            // Act
            Rhomb rhomb = new Rhomb(A, H);
            double actual = rhomb.Area();
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

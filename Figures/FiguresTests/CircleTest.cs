using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CirclePerimeterTest()
        {
            // Arrange
            double radius = 2.5;
            double expected = 15.7;

            // Act
            Circle circle = new Circle(radius);
            double actual = circle.Perimeter();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CircleAreaTest()
        {
            // Arrange
            double radius = 2.5;
            double expected = 19.6;

            // Act
            Circle circle = new Circle(radius);
            double actual = circle.Area();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(CircleException))]
        public void CircleZeroRadiusTestMethod()
        {
            double radius = 0;

            try
            {
                Circle circle = new Circle(radius);
            }
            catch (CircleException)
            {
                throw;
            }
        }
    }
}

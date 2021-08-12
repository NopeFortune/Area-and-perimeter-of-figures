using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTests
{
    [TestClass]
    public class ParallelogramTest
    {
        [TestMethod]
        public void ParallelogramPerimeterTest()
        {
            // Arrange
            double A = 2;
            double B = 3;
            double H = 6;
            double expected = 10;

            // Act
            Parallelogram parallelogram = new Parallelogram(A, B, H);
            double actual = parallelogram.Perimeter();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParallelogramAreaTest()
        {
            // Arrange
            double A = 2;
            double B = 3;
            double H = 6;
            double expected = 12;

            // Act
            Parallelogram parallelogram = new Parallelogram(A, B, H);
            double actual = parallelogram.Area();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ParallelogramException))]
        public void ParallelogramZeroSideTestMethod()
        {
            double a = 0;
            double b = 0;
            double h = 0;

            try
            {
                Parallelogram parallelogram = new Parallelogram(a, b, h);
            }
            catch (ParallelogramException)
            {
                throw;
            }
        }
    }
}

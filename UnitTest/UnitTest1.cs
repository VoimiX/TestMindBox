using System;

using FigureLib;
using FigureLib.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        const double error = 0.01;

        [TestMethod]
        public void Test_CircleSquare_IsCorrect()
        {
            var rad = 5;
            var c = FigureFabric.CreateCircle(rad);
            Assert.IsTrue(Math.Abs(c.Square - 78.539) < error);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Circle_InvalidRadius_ThrowsException()
        {
            var c = FigureFabric.CreateCircle(-5);
        }

        [TestMethod]
        public void Test_TriangleSquare_IsCorrect()
        {         
            var c = FigureFabric.CreateTriange(2, 3, 3.605);
            Assert.IsTrue(Math.Abs(c.Square - 3) < error);
        }

        [TestMethod]
        public void Test_Triangle_IsRectangular()
        {           
            var t = FigureFabric.CreateTriange(2, 3, 3.605);
            Assert.IsTrue(((Triangle)t).IsRectangular);
        }

        [DataTestMethod]
        [DataRow(2, 1, -1)]
        [DataRow(-2, 1, 4)]
        [DataRow(0, -4, 1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Triangle_InvalidSide_ThrowsException(double a, double b, double c)
        {
            FigureFabric.CreateTriange(a, b, c);
        }
    }
}

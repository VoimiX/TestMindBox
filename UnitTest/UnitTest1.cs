using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLib;
using FigureLib.Figures;

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
        public void Test_TriangeSquare_IsCorrect()
        {         
            var c = FigureFabric.CreateTriange(2, 3, 3.605);
            Assert.IsTrue(Math.Abs(c.Square - 3) < error);
        }

        [TestMethod]
        public void Test_Triange_IsRectangular()
        {           
            var t = FigureFabric.CreateTriange(2, 3, 3.605);
            Assert.IsTrue(((Triangle)t).IsRectangular);
        }
    }
}

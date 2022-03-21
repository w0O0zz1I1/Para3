using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using System;

namespace ServiceUnitTest
{
    [TestClass]
    public class SquareTest
    {
        string aNotNull = "Первое слогаемое не может быть = 0";
        string notSqrt = "Нет корней";
        [TestMethod]
        public void SquareTestMethod()
        {
            Assert.AreEqual(Square.SquareMethod(0, 0, 0), aNotNull);
            Assert.AreEqual(Square.SquareMethod(1, 1, 1), notSqrt);
            Assert.AreEqual(Square.SquareMethod(-10, 0, 0), "Корень x1 =0");
            Assert.AreEqual(Square.SquareMethod(2, 5, 3), "Корень x1 =-1\n Корень x2 = -1,5");
        }
    }
}

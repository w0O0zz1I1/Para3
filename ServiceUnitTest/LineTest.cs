using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceUnitTest
{
    [TestClass]
    public class LineTest
    {
        [TestMethod]
        public void lineTestMethod()
        {
            Assert.AreEqual(Service.Line.LineMethod(8, -4), "Ответ 0,5");
        }
    }
}

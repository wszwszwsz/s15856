using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeral.Tests
{
    [TestClass()]
    public class RomanTests
    {
        [TestMethod()]
        public void fromRomanTest()
        {
            int res = Roman.fromRoman("L");
            Assert.AreEqual(50, res);
        }

        [TestMethod()]
        public void toRomanTest()
        {
            String res = Roman.toRoman(100);
            Assert.AreEqual("C", res);
        }
    }
}
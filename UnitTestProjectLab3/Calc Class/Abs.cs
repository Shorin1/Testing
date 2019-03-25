using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class Abs
    {
        private void AbsTest()
        {
            Random ran = new Random();
            long a = ran.Next(int.MinValue, int.MaxValue);
            long expected = Math.Abs(a);
            long result = BaseCalculator.CalcClass.ABS(a);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Abs1()
        {
            AbsTest();
        }

        [TestMethod]
        public void Abs2()
        {
            AbsTest();
        }

        [TestMethod]
        public void Abs3()
        {
            AbsTest();
        }

        [TestMethod]
        public void Abs4()
        {
            AbsTest();
        }

        [TestMethod]
        public void Abs5()
        {
            AbsTest();
        }
    }
}

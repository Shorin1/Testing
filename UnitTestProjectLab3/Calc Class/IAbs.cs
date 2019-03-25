using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class IAbs
    {
        private void IAbsTest()
        {
            Random ran = new Random();
            long a = ran.Next(int.MinValue, int.MaxValue);
            long expected = -a;
            long result = BaseCalculator.CalcClass.IABS(a);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IAbs1()
        {
            IAbsTest();
        }

        [TestMethod]
        public void IAbs2()
        {
            IAbsTest();
        }

        [TestMethod]
        public void IAbs3()
        {
            IAbsTest();
        }

        [TestMethod]
        public void IAbs4()
        {
            IAbsTest();
        }

        [TestMethod]
        public void IAbs5()
        {
            IAbsTest();
        }
    }
}

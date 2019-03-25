using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class Sub
    {
        private void SubTest()
        {
            Random ran = new Random();
            int a = ran.Next(int.MaxValue);
            int b = ran.Next(int.MaxValue);
            long expected = 0;
            if (a - b <= int.MaxValue && a - b >= int.MinValue)
            {
                expected = a - b;
            }
            long result = BaseCalculator.CalcClass.Sub(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sub1()
        {
            SubTest();
        }

        [TestMethod]
        public void Sub2()
        {
            SubTest();
        }

        [TestMethod]
        public void Sub3()
        {
            SubTest();
        }

        [TestMethod]
        public void Sub4()
        {
            SubTest();
        }

        [TestMethod]
        public void Sub5()
        {
            SubTest();
        }

    }
}

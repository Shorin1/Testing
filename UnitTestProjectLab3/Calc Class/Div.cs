using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class Div
    {
        private void DivTest()
        {
            Random ran = new Random();
            int a = ran.Next(int.MinValue, int.MaxValue);
            int b = ran.Next(int.MinValue, int.MaxValue);
            long expected = 0;
            if (b != 0)
            {
                expected = a / b;
            }
            long result = BaseCalculator.CalcClass.Div(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Div1()
        {
            DivTest();
        }

        [TestMethod]
        public void Div2()
        {
            DivTest();
        }

        [TestMethod]
        public void Div3()
        {
            DivTest();
        }

        [TestMethod]
        public void Div4()
        {
            DivTest();
        }

        [TestMethod]
        public void Div5()
        {
            DivTest();
        }
    }
}

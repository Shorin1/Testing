using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class Mult
    {
        private void MultTest ()
        {
            Random ran = new Random();
            int a = ran.Next(int.MinValue, int.MaxValue);
            int b = ran.Next(int.MinValue, int.MaxValue);
            BigInteger bia = a;
            BigInteger bib = b;
            int expected = 0;
            BigInteger temp =  bia * bib;
            if (temp <= int.MaxValue && temp >= int.MinValue)
            {
                expected = a * b;
            }
            int result = BaseCalculator.CalcClass.Mult(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Mult1()
        {
            MultTest();
        }

        [TestMethod]
        public void Mult2()
        {
            MultTest();
        }

        [TestMethod]
        public void Mult3()
        {
            MultTest();
        }

        [TestMethod]
        public void Mult4()
        {
            MultTest();
        }

        [TestMethod]
        public void Mult5()
        {
            MultTest();
        }
    }
}

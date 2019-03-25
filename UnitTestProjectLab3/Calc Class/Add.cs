using System;
using BaseCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Add
    {
        private void AddTest()
        {
            Random ran = new Random();
            long a = ran.Next(int.MaxValue);
            long b = ran.Next(int.MaxValue);
            long expected = 0;
            long result = CalcClass.Add(a, b);
            if (a + b <= int.MaxValue)
            {
                expected = a + b;
            }
            Assert.AreEqual(expected, result);
        }
        

        [TestMethod]
        public void Add1()
        {
            AddTest();
        }

        [TestMethod]
        public void Add2()
        {
            AddTest();
        }

        [TestMethod]
        public void Add3()
        {
            AddTest();
        }

        [TestMethod]
        public void Add4()
        {
            AddTest();
        }

        [TestMethod]
        public void Add5()
        {
            AddTest();
        }
    }
}

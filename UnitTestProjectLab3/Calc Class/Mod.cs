using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class Mod
    {
        private void ModTest()
        {
            Random ran = new Random();
            long a = ran.Next(int.MinValue, int.MaxValue);
            long b = ran.Next(int.MinValue, int.MaxValue);
            long expected = 0;
            if (b != 0)
            {
                Math.DivRem(a, b, out expected);
            }
            long result = BaseCalculator.CalcClass.Mod(a, b);
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        public void Mud1()
        {
            ModTest();
        }

        [TestMethod]
        public void Mud2()
        {
            ModTest();
        }

        [TestMethod]
        public void Mud3()
        {
            ModTest();
        }

        [TestMethod]
        public void Mud4()
        {
            ModTest();
        }

        [TestMethod]
        public void Mud5()
        {
            ModTest();
        }
    }
}

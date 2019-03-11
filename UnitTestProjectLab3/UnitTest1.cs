using System;
using System.Collections;
using BaseCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectLab3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcClassAdd1()
        {
            Random ran = new Random();
            long a = ran.Next(int.MaxValue);
            long b = ran.Next(int.MaxValue);
            if (a + b <= int.MaxValue)
            {
                long result = CalcClass.Add(a, b);
                Assert.AreEqual(result, a + b);
            }
        }

        [TestMethod]
        public void CalcClassAdd2()
        {
            Random ran = new Random();
            long a = ran.Next(int.MaxValue);
            long b = ran.Next(int.MaxValue);
            if (a + b <= int.MaxValue)
            {
                long result = CalcClass.Add(a, b);
                Assert.AreEqual(result, a + b);
            }
        }

        [TestMethod]
        public void CalcClassAdd3()
        {
            Random ran = new Random();
            long a = ran.Next(int.MaxValue);
            long b = ran.Next(int.MaxValue);
            if (a + b <= int.MaxValue)
            {
                long result = CalcClass.Add(a, b);
                Assert.AreEqual(result, a + b);
            }
        }

        [TestMethod]
        public void CheckCurrency1()
        {
            AnalaizerClass.expression = "(((())(";
            bool result = AnalaizerClass.CheckCurrency();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckCurrency2()
        {
            AnalaizerClass.expression = "(())";
            bool result = AnalaizerClass.CheckCurrency();
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckCurrency3()
        {
            AnalaizerClass.expression = "((((()))(())()()()";
            bool result = AnalaizerClass.CheckCurrency();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckCurrency4()
        {
            AnalaizerClass.expression = "(";
            bool result = AnalaizerClass.CheckCurrency();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckCurrency5()
        {
            AnalaizerClass.expression = "( ((((( (((     ))) ) )))  )))";
            bool result = AnalaizerClass.CheckCurrency();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Format1()
        {
            AnalaizerClass.expression = "5+2";
            string result = AnalaizerClass.Format();
            string expected = "5 + 2 ";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Format2()
        {
            AnalaizerClass.expression = "   5     +  2";
            string result = AnalaizerClass.Format();
            string expected = "5 + 2 ";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Format3()
        {
            AnalaizerClass.expression = "          5+2           ";
            string result = AnalaizerClass.Format();
            string expected = "5 + 2 ";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Format4()
        {
            AnalaizerClass.expression = "          5+2           ";
            string result = AnalaizerClass.Format();
            string expected = "5 + 2 ";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Format5()
        {
            AnalaizerClass.expression = "1+2*(2-1)";
            string expected = "1 + 2 * ( 2 - 1 ) ";
            string result = AnalaizerClass.Format();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CreateStack1()
        {
            AnalaizerClass.expression = "5 + 2 ";
            ArrayList result = AnalaizerClass.CreateStack();
            ArrayList expected = new ArrayList { "5", "2", "+" };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void CreateStack2()
        {
            AnalaizerClass.expression = "4 / 2 * 5 ";
            ArrayList result = AnalaizerClass.CreateStack();
            ArrayList expected = new ArrayList { "4", "2", "/", "5", "*" };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void CreateStack3()
        {
            AnalaizerClass.expression = "3 * ( 4 + 2 ) - 1 ";
            ArrayList result = AnalaizerClass.CreateStack();
            ArrayList expected = new ArrayList { "3", "4", "2", "+", "*", "1", "-" };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void CreateStack4()
        {
            AnalaizerClass.expression = "2 - 1 * 5 + 7 ";
            ArrayList result = AnalaizerClass.CreateStack();
            ArrayList expected = new ArrayList { "2", "1", "5", "*", "-", "7", "+" };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void CreateStack5()
        {
            AnalaizerClass.expression = "7 - 5 * 1 - 2 + ( 2 / 1 ) ";
            ArrayList result = AnalaizerClass.CreateStack();
            ArrayList expected = new ArrayList { "7", "5", "1", "*", "-", "2", "-", "2", "1", "/", "+" };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void RunEstimate1()
        {
            AnalaizerClass.opz = new ArrayList { "5", "2", "+" };
            string result = AnalaizerClass.RunEstimate();
            string expected = "7";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RunEstimate2()
        {
            AnalaizerClass.opz = new ArrayList { "4", "2", "/", "5", "*" };
            string result = AnalaizerClass.RunEstimate();
            string expected = "10";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RunEstimate3()
        {
            AnalaizerClass.opz = new ArrayList { "3", "4", "2", "+", "*", "1", "-" };
            string result = AnalaizerClass.RunEstimate();
            string expected = "17";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RunEstimate4()
        {
            AnalaizerClass.opz = new ArrayList { "2", "1", "5", "*", "-", "7", "+" };
            string result = AnalaizerClass.RunEstimate();
            string expected = "4";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RunEstimate5()
        {
            AnalaizerClass.opz = new ArrayList { "7", "5", "1", "*", "-", "2", "-", "2", "1", "/", "+" };
            string result = AnalaizerClass.RunEstimate();
            string expected = "2";
            Assert.AreEqual(expected, result);
        }
    }
}

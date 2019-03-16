using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseCalculator;

namespace UnitTestProjectLab3
{
    [TestClass]
    public class UnitTest1
    {
        Random ran = new Random();
        [TestMethod]
        public void CalcClassAdd1()
        {
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
            Assert.AreEqual(false, AnalaizerClass.CheckCurrency());
        }

        [TestMethod]
        public void CheckCurrency2()
        {
            AnalaizerClass.expression = "(())";
            Assert.AreEqual(true, AnalaizerClass.CheckCurrency());
        }

        [TestMethod]
        public void CheckCurrency3()
        {
            AnalaizerClass.expression = "((((()))(())()()()";
            Assert.AreEqual(false, AnalaizerClass.CheckCurrency());
        }

        [TestMethod]
        public void CheckCurrency4()
        {
            AnalaizerClass.expression = "(";
            Assert.AreEqual(false, AnalaizerClass.CheckCurrency());
        }

        [TestMethod]
        public void CheckCurrency5()
        {
            AnalaizerClass.expression = "( ((((( (((     ))) ) )))  )))";
            Assert.AreEqual(false, AnalaizerClass.CheckCurrency());
        }

        [TestMethod]
        public void Format1()
        {
            AnalaizerClass.expression = "5+2";
            Assert.AreEqual("5 + 2 ", AnalaizerClass.Format());
        }

        [TestMethod]
        public void Format2()
        {
            AnalaizerClass.expression = "   5     +  2";
            Assert.AreEqual("5 + 2 ", AnalaizerClass.Format());
        }

        [TestMethod]
        public void Format3()
        {
            AnalaizerClass.expression = "          5+2           ";
            Assert.AreEqual("5 + 2 ", AnalaizerClass.Format());
        }

        [TestMethod]
        public void Format4()
        {
            AnalaizerClass.expression = "          5+2           ";
            Assert.AreEqual("5 + 2 ", AnalaizerClass.Format());
        }

        [TestMethod]
        public void Format5()
        {
            AnalaizerClass.expression = "1+2*(2-1)";
            Assert.AreEqual("1 + 2 * ( 2 - 1 ) ", AnalaizerClass.Format());
        }

        [TestMethod]
        public void CreateStack1()
        {
            AnalaizerClass.expression = "3 + 1 ";
            ArrayList result = AnalaizerClass.CreateStack();
            ArrayList expected = new ArrayList { "3", "1", "+" };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void CreateStack2()
        {
            AnalaizerClass.expression = "6 / 2 * 1 ";
            ArrayList result = AnalaizerClass.CreateStack();
            ArrayList expected = new ArrayList { "6", "2", "/", "1", "*" };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void CreateStack3()
        {
            AnalaizerClass.expression = "2 * ( 4 + 2 ) - 1 ";
            ArrayList result = AnalaizerClass.CreateStack();
            ArrayList expected = new ArrayList { "2", "4", "2", "+", "*", "1", "-" };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void CreateStack4()
        {
            AnalaizerClass.expression = "2 - 1 * 5 + 5 ";
            ArrayList result = AnalaizerClass.CreateStack();
            ArrayList expected = new ArrayList { "2", "1", "5", "*", "-", "5", "+" };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void CreateStack5()
        {
            AnalaizerClass.expression = "1 - 5 * 1 - 2 + ( 2 / 1 ) ";
            ArrayList result = AnalaizerClass.CreateStack();
            ArrayList expected = new ArrayList { "1", "5", "1", "*", "-", "2", "-", "2", "1", "/", "+" };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void RunEstimate1()
        {
            AnalaizerClass.opz = new ArrayList { "5", "2", "+" };
            Assert.AreEqual("7", AnalaizerClass.RunEstimate());
        }

        [TestMethod]
        public void RunEstimate2()
        {
            AnalaizerClass.opz = new ArrayList { "4", "2", "/", "5", "*" };
            Assert.AreEqual("10", AnalaizerClass.RunEstimate());
        }

        [TestMethod]
        public void RunEstimate3()
        {
            AnalaizerClass.opz = new ArrayList { "3", "4", "2", "+", "*", "1", "-" };
            Assert.AreEqual("17", AnalaizerClass.RunEstimate());
        }

        [TestMethod]
        public void RunEstimate4()
        {
            AnalaizerClass.opz = new ArrayList { "2", "1", "5", "*", "-", "7", "+" };
            Assert.AreEqual("4", AnalaizerClass.RunEstimate());
        }

        [TestMethod]
        public void RunEstimate5()
        {
            AnalaizerClass.opz = new ArrayList { "7", "5", "1", "*", "-", "2", "-", "2", "1", "/", "+" };
            Assert.AreEqual("2", AnalaizerClass.RunEstimate());
        }
    }
}

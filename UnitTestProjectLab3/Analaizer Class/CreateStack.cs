using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseCalculator;
using System.Collections;

namespace UnitTestProject.Analaizer_Class
{
    [TestClass]
    public class CreateStack
    {
        private void CreateStackTest(string input, ArrayList expected)
        {
            AnalaizerClass.expression = input;
            ArrayList result = AnalaizerClass.CreateStack();
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
           
        }

        [TestMethod]
        public void CreateStack1()
        {
            CreateStackTest("5 + 2 ", new ArrayList { "5", "2", "+" });
        }

        [TestMethod]
        public void CreateStack2()
        {
            CreateStackTest("", new ArrayList());
        }

        [TestMethod]
        public void CreateStack3()
        {
            CreateStackTest("3 * ( 4 + 2 ) - 1 ", new ArrayList { "3", "4", "2", "+", "*", "1", "-" });
        }

        [TestMethod]
        public void CreateStack4()
        {
            CreateStackTest("2 - 1 * 5 + 7 ", new ArrayList { "2", "1", "5", "*", "-", "7", "+" });
        }

        [TestMethod]
        public void CreateStack5()
        {
            CreateStackTest("7 - 5 * 1 - 2 + ( 2 / 1 ) ", new ArrayList { "7", "5", "1", "*", "-", "2", "-", "2", "1", "/", "+" });
        }
    }
}

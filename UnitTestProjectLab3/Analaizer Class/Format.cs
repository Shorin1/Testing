using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseCalculator;

namespace UnitTestProject.Analaizer_Class
{
    [TestClass]
    public class Format
    {
        private void FormatTest(string input, string expected)
        {
            AnalaizerClass.expression = input;
            string result = AnalaizerClass.Format();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Format1()
        {
            FormatTest("5+2", "5 + 2 ");
        }

        [TestMethod]
        public void Format2()
        {
            FormatTest("   5     +  2", "5 + 2 ");
        }

        [TestMethod]
        public void Format3()
        {
            FormatTest("  d        5+2       fs    ", "&Error 02 at 2");
        }

        [TestMethod]
        public void Format4()
        {
            FormatTest("", " ");
        }

        [TestMethod]
        public void Format5()
        {
            FormatTest("1+2*(2-1)", "1 + 2 * ( 2 - 1 ) ");
        }
    }
}

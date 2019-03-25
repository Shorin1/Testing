using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseCalculator;

namespace UnitTestProject.Analaizer_Class
{
    [TestClass]
    public class CheckCurrency
    {
        private void CheckCurrencyTest(string input, bool expected)
        {
            AnalaizerClass.expression = input;
            bool result = AnalaizerClass.CheckCurrency();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckCurrency1()
        {
            CheckCurrencyTest("(((())(", false);
        }

        [TestMethod]
        public void CheckCurrency2()
        {
            CheckCurrencyTest("(             (ffff)g)", true);
        }

        [TestMethod]
        public void CheckCurrency3()
        {
            CheckCurrencyTest("(dsfsdgfs((((erewhgfsfdsfh))(eadf))()gsfh()()", false);
        }

        [TestMethod]
        public void CheckCurrency4()
        {
            CheckCurrencyTest("(", false);
        }

        [TestMethod]
        public void CheckCurrency5()
        {
            CheckCurrencyTest("", true);
        }
    }
}


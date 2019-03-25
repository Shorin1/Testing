using BaseCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.Analaizer_Class
{
    [TestClass]
    public class Estimate
    {
        private void EstimateTest(string input, string expected)
        {
            AnalaizerClass.expression = input;
            string result = AnalaizerClass.Estimate();
            Assert.AreEqual(expected, result);
        }
      
        [TestMethod]
        public void Estimate1()
        {
            EstimateTest("3 + 3", "6");
        }

        [TestMethod]
        public void Estimate2()
        {
            EstimateTest("", "");
        }

        [TestMethod]
        public void Estimate3()
        {
            EstimateTest("2 +", "Error 05");
        }

        [TestMethod]
        public void Estimate4()
        {
            EstimateTest("1/0", "Error 09");
        }

        [TestMethod]
        public void Estimate5()
        {
            EstimateTest("Test", "Error 02 at 0");
        }
    }
}

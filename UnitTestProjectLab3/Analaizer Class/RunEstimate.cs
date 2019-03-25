using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseCalculator;
using System.Collections;

namespace UnitTestProject.Analaizer_Class
{

    [TestClass]
    public class RunEstimate
    {
        private void RunEstimateTest(ArrayList input, string expected)
        {
            AnalaizerClass.opz = input;
            string result = AnalaizerClass.RunEstimate();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RunEstimate1()
        {
            RunEstimateTest(new ArrayList { "5", "2", "+" }, "7");
        }

        [TestMethod]
        public void RunEstimate2()
        {
            RunEstimateTest(new ArrayList { "4", "2", "/", "5", "*" }, "10");
        }

        [TestMethod]
        public void RunEstimate3()
        {
            RunEstimateTest(new ArrayList { "3", "4", "2", "+", "*", "1", "-" }, "17");
        }

        [TestMethod]
        public void RunEstimate4()
        {
            RunEstimateTest(new ArrayList { "2", "1", "5", "*", "-", "7", "+" }, "4");
        }

        [TestMethod]
        public void RunEstimate5()
        {
            RunEstimateTest(new ArrayList { "7", "5", "1", "*", "-", "2", "-", "2", "1", "/", "+" }, "2");
        }
    }
}

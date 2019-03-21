using BaseCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using System.Text;

namespace UnitTestProject.Analaizer_Class
{
    [TestClass]
    public class Estimate
    {
        private const string COMPONENT_NAME = "AnalaizlerClass.Estimate";

        private static Logger logger = LoggingConfiguration();

        private static Logger LoggingConfiguration()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = @"Log\Analaizer Class\Estimate.txt" };

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);
            LogManager.Configuration = config;
            Logger logger = LogManager.GetCurrentClassLogger();
            return logger;
        }

        private void EstimateTest(int testNumber, string input, string expected)
        {
            AnalaizerClass.expression = input;
            string result = AnalaizerClass.Estimate();
            
            if (expected == result)
            {
                Log.CreateLogInfo(logger, testNumber, input, expected, result);
            }
            else
            {
                Log.CreateBugReport(logger, COMPONENT_NAME, testNumber, input, expected, result);
            }
            Assert.AreEqual(expected, result);
        }
      
        [TestMethod]
        public void Estimate1()
        {
            EstimateTest(1, "2 + 2", "4");
        }

        [TestMethod]
        public void Estimate2()
        {
            EstimateTest(2, "", "");
        }

        [TestMethod]
        public void Estimate3()
        {
            EstimateTest(3, "2 +", "Error 05");
        }

        [TestMethod]
        public void Estimate4()
        {
            EstimateTest(4, "1/0", "Error 09");
        }

        [TestMethod]
        public void Estimate5()
        {
            EstimateTest(5, "Test", "Error 02 at 0");
        }
    }
}

using BaseCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace UnitTestProject.Analaizer_Class
{
    [TestClass]
    public class Estimate
    {
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

        private void EstimateTest(int numberTest, string input, string expected)
        {
            AnalaizerClass.expression = input;
            string result = AnalaizerClass.Estimate();
            string logInfo = string.Format("\nНомер теста: {0}\nВходные данные: {1}\nОжидаемый результат: {2}\nПолученный результат: {3}", numberTest, input, expected, result);
            if (expected == result)
            {
                logger.Info(logInfo);
            }
            else
            {
                logger.Error(logInfo);
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
            EstimateTest(2, "3 * ( 4 + 2 ) - 1", "17");
        }

        [TestMethod]
        public void Estimate3()
        {
            EstimateTest(3, "2 - 1 * 5 + 7", "4");
        }

        [TestMethod]
        public void Estimate4()
        {
            EstimateTest(4, "7 - 5 * 1 - 2 + ( 2 / 1 )", "2");
        }

        [TestMethod]
        public void Estimate5()
        {
            EstimateTest(5, "4 / 2k * 5", "10");
        }
    }
}

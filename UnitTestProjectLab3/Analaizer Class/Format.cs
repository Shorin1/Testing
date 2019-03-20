using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using BaseCalculator;

namespace UnitTestProject.Analaizer_Class
{
    [TestClass]
    public class Format
    {
        private static Logger logger = LoggingConfiguration();

        private static Logger LoggingConfiguration()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = @"Log\Analaizer Class\Format.txt" };

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);
            LogManager.Configuration = config;
            Logger logger = LogManager.GetCurrentClassLogger();
            return logger;
        }

        private void FormatTest(int numberTest, string input, string expected)
        {
            AnalaizerClass.expression = input;
            string result = AnalaizerClass.Format();
            string logInfo = string.Format("\nNumber test: {0}()\nВходные данные: {1}\nОжидаемый результат: {2}\nПолученный результат result = {3}\n", numberTest, input, expected, result);

            if (result == expected)
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
        public void Format1()
        {
            FormatTest(1, "5+2", "5 + 2 ");
        }

        [TestMethod]
        public void Format2()
        {
            FormatTest(2, "   5     +  2", "5 + 2 ");
        }

        [TestMethod]
        public void Format3()
        {
            FormatTest(3, "          5+2           ", "5 + 2 ");
        }

        [TestMethod]
        public void Format4()
        {
            FormatTest(4, "          5+2           ", "5 + 2 ");
        }

        [TestMethod]
        public void Format5()
        {
            FormatTest(5, "1+2*(2-1)", "1 + 2 * ( 2 - 1 ) ");
        }
    }
}

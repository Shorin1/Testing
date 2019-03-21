using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using BaseCalculator;

namespace UnitTestProject.Analaizer_Class
{
    [TestClass]
    public class CheckCurrency
    {
        private const string COMPONENT_NAME = "AnalaizerClass.CheckCurrency";
        private const string LOG_FILE_NAME = @"Log\Analaizer Class\CheckCurrency.txt";

        private static Logger logger = LoggingConfiguration();

        private static Logger LoggingConfiguration()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = LOG_FILE_NAME };

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);
            LogManager.Configuration = config;
            Logger logger = LogManager.GetCurrentClassLogger();
            return logger;
        }

        private void CheckCurrencyTest(int testNumber, string input, bool expected)
        {
            AnalaizerClass.expression = input;
            bool result = AnalaizerClass.CheckCurrency();

            if (result == expected)
            {
                Log.CreateLogInfo(logger, testNumber, input, expected.ToString(), result.ToString());
            }
            else
            {
                Log.CreateBugReport(logger, COMPONENT_NAME, testNumber, input, expected.ToString(), result.ToString());
            }
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckCurrency1()
        {
            CheckCurrencyTest(1, "(((())(", false);
        }

        [TestMethod]
        public void CheckCurrency2()
        {
            CheckCurrencyTest(2, "(             (ffff)g)", true);
        }

        [TestMethod]
        public void CheckCurrency3()
        {
            CheckCurrencyTest(3, "(dsfsdgfs((((erewhgfsfdsfh))(eadf))()gsfh()()", false);
        }

        [TestMethod]
        public void CheckCurrency4()
        {
            CheckCurrencyTest(4, "(", false);
        }

        [TestMethod]
        public void CheckCurrency5()
        {
            CheckCurrencyTest(4, "", true);
        }
    }
}


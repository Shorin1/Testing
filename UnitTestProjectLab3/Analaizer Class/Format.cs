using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using BaseCalculator;

namespace UnitTestProject.Analaizer_Class
{
    [TestClass]
    public class Format
    {
        private const string COMPONENT_NAME = "AnalaizerClass.Format";
        private const string LOG_FILE_NAME = @"Log\Analaizer Class\Format.txt";

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

        private void FormatTest(int testNumber, string input, string expected)
        {
            AnalaizerClass.expression = input;
            string result = AnalaizerClass.Format();

            if (result == expected)
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
            FormatTest(3, "  d        5+2       fs    ", "&Error 02 at 2");
        }

        [TestMethod]
        public void Format4()
        {
            FormatTest(4, "", " ");
        }

        [TestMethod]
        public void Format5()
        {
            FormatTest(5, "1+2*(2-1)", "1 + 2 * ( 2 - 1 ) ");
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class Sub
    {
        private const string COMPONENT_NAME = "CalcClass.Sub";
        private const string LOG_FILE_NAME = @"Log\Calc class\Sub.txt";

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

        private void SubTest(int testNumber)
        {
            Random ran = new Random();
            int a = ran.Next(int.MaxValue);
            int b = ran.Next(int.MaxValue);
            long expected = 0;

            if (a - b <= int.MaxValue && a - b >= int.MinValue)
            {
                expected = a - b;
            }

            long result = BaseCalculator.CalcClass.Sub(a, b);
            if (result == expected)
            {
                Log.CreateLogInfo(logger, testNumber, InputToString(a, b), expected.ToString(), result.ToString());
            }
            else
            {
                Log.CreateBugReport(logger, COMPONENT_NAME, testNumber, InputToString(a, b), expected.ToString(), result.ToString());
            }
            Assert.AreEqual(expected, result);
        }

        private string InputToString(int a, int b)
        {
            return string.Format("{0} {1}", a, b);
        }

        [TestMethod]
        public void Sub1()
        {
            SubTest(1);
        }

        [TestMethod]
        public void Sub2()
        {
            SubTest(2);
        }

        [TestMethod]
        public void Sub3()
        {
            SubTest(3);
        }

        [TestMethod]
        public void Sub4()
        {
            SubTest(4);
        }

        [TestMethod]
        public void Sub5()
        {
            SubTest(5);
        }

    }
}

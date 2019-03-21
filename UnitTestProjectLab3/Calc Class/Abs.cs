using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class Abs
    {
        private const string COMPONENT_NAME = "CalcClass.Abs";
        private const string LOG_FILE_NAME = @"Log\Calc class\Abs.txt";

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

        private void AbsTest(int testNumber)
        {
            Random ran = new Random();
            long a = ran.Next(int.MinValue, int.MaxValue);
            long expected = Math.Abs(a);
            long result = BaseCalculator.CalcClass.ABS(a);
            if (expected == result)
            {
                Log.CreateLogInfo(logger, testNumber, a.ToString(), expected.ToString(), result.ToString());
            }
            else
            {
                Log.CreateBugReport(logger, COMPONENT_NAME, testNumber, a.ToString(), expected.ToString(), result.ToString());
            }
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Abs1()
        {
            AbsTest(1);
        }

        [TestMethod]
        public void Abs2()
        {
            AbsTest(2);
        }

        [TestMethod]
        public void Abs3()
        {
            AbsTest(3);
        }

        [TestMethod]
        public void Abs4()
        {
            AbsTest(4);
        }

        [TestMethod]
        public void Abs5()
        {
            AbsTest(5);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class IAbs
    {
        private const string COMPONENT_NAME = "CalcClass.IAbs";
        private const string LOG_FILE_NAME = @"Log\Calc class\IAbs.txt";

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

        private void IAbsTest(int testNumber)
        {
            Random ran = new Random();
            long a = ran.Next(int.MinValue, int.MaxValue);
            long expected = 0;
            if (a > 0)
            {
                expected = -a;
            }
            else
            {
                expected = a;
            }

            long result = BaseCalculator.CalcClass.IABS(a);

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
        public void IAbs1()
        {
            IAbsTest(1);
        }

        [TestMethod]
        public void IAbs2()
        {
            IAbsTest(2);
        }

        [TestMethod]
        public void IAbs3()
        {
            IAbsTest(3);
        }

        [TestMethod]
        public void IAbs4()
        {
            IAbsTest(4);
        }

        [TestMethod]
        public void IAbs5()
        {
            IAbsTest(5);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class Div
    {
        private const string COMPONENT_NAME = "CalcClass.Div";
        private const string LOG_FILE_NAME = @"Log\Calc class\Div.txt";

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

        private void DivTest(int testNumber)
        {
            Random ran = new Random();
            int a = ran.Next(int.MinValue, int.MaxValue);
            int b = ran.Next(int.MinValue, int.MaxValue);
            long expected = 0;
            if (b != 0)
            {
                expected = a / b;
            }
            long result = BaseCalculator.CalcClass.Div(a, b);

            if (expected == result)
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
        public void Div1()
        {
            DivTest(1);
        }

        [TestMethod]
        public void Div2()
        {
            DivTest(2);
        }

        [TestMethod]
        public void Div3()
        {
            DivTest(4);
        }

        [TestMethod]
        public void Div4()
        {
            DivTest(4);
        }

        [TestMethod]
        public void Div5()
        {
            DivTest(5);
        }
    }
}

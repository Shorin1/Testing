using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using System.Numerics;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class Mult
    {
        private const string COMPONENT_NAME = "CalcClass.Mult";
        private const string LOG_FILE_NAME = @"Log\Calc class\Mult.txt";

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

        private void MultTest (int testNumber)
        {
            Random ran = new Random();
            int a = ran.Next(int.MinValue, int.MaxValue);
            int b = ran.Next(int.MinValue, int.MaxValue);
            BigInteger bia = a;
            BigInteger bib = b;
            BigInteger temp = bia * bib;
            BigInteger expected = 0;

            if (temp <= int.MaxValue && temp >= int.MinValue)
            {
                expected = a*b;
            }

            long result = BaseCalculator.CalcClass.Mult(a, b);

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
        public void Mult1()
        {
            MultTest(1);
        }

        [TestMethod]
        public void Mult2()
        {
            MultTest(2);
        }

        [TestMethod]
        public void Mult3()
        {
            MultTest(3);
        }

        [TestMethod]
        public void Mult4()
        {
            MultTest(4);
        }

        [TestMethod]
        public void Mult5()
        {
            MultTest(5);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace UnitTestProject.Calc_Class
{
    [TestClass]
    public class Mod
    {
        private const string COMPONENT_NAME = "CalcClass.Mod";
        private const string LOG_FILE_NAME = @"Log\Calc class\Mod.txt";

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

        private void ModTest(int testNumber)
        {
            Random ran = new Random();
            long a = ran.Next(int.MinValue, int.MaxValue);
            long b = ran.Next(int.MinValue, int.MaxValue);
            long expected = 0;

            if (b != 0)
            {
                Math.DivRem(a, b, out expected);
            }

            long result = BaseCalculator.CalcClass.Mod(a, b);

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

        private string InputToString(long a, long b)
        {
            return string.Format("{0} {1}", a, b);
        }

        [TestMethod]
        public void Mud1()
        {
            ModTest(1);
        }

        [TestMethod]
        public void Mud2()
        {
            ModTest(3);
        }

        [TestMethod]
        public void Mud3()
        {
            ModTest(3);
        }

        [TestMethod]
        public void Mud4()
        {
            ModTest(4);
        }

        [TestMethod]
        public void Mud5()
        {
            ModTest(5);
        }
    }
}

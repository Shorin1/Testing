using System;
using BaseCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace UnitTestProject
{
    [TestClass]
    public class Add
    {
        private const string COMPANENT_NAME = "CalcClass.Add";
        private const string LOG_FILE_NAME = @"Log\Calc class\Add.txt";

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

        private void AddTest(int testNumber)
        {
            Random ran = new Random();
            long a = ran.Next(int.MaxValue);
            long b = ran.Next(int.MaxValue);
            long expected = 0;
            long result = CalcClass.Add(a, b);
           
            if (a + b <= int.MaxValue)
            {
                expected = a + b;
            }

            if (expected == result)
            {
                Log.CreateLogInfo(logger, testNumber, InputToString(a, b), expected.ToString(), result.ToString());
            }
            else
            {
                Log.CreateBugReport(logger, COMPANENT_NAME, testNumber, InputToString(a, b), expected.ToString(), result.ToString()); 
            } 
        }

        private string InputToString (long a, long b)
        {
            return string.Format("{0}, {1}", a, b);
        }

        [TestMethod]
        public void Add1()
        {
            AddTest(1);
        }

        [TestMethod]
        public void Add2()
        {
            AddTest(2);
        }

        [TestMethod]
        public void Add3()
        {
            AddTest(3);
        }

        [TestMethod]
        public void Add4()
        {
            AddTest(4);
        }

        [TestMethod]
        public void Add5()
        {
            AddTest(5);
        }
    }
}

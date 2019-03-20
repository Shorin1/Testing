using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using BaseCalculator;
using System.Collections;

namespace UnitTestProject.Analaizer_Class
{

    [TestClass]
    public class RunEstimate
    {
        private static Logger logger = LoggingConfiguration();

        private static Logger LoggingConfiguration()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = @"Log\Analaizer Class\RunEstimate.txt" };

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);
            LogManager.Configuration = config;
            Logger logger = LogManager.GetCurrentClassLogger();
            return logger;
        }

        private void RunEstimateTest(int testNumber, ArrayList input, string expected)
        {
            AnalaizerClass.opz = input;
            StringBuilder logInfo = new StringBuilder();
            logInfo.Append("\nTest number: ").Append(testNumber).Append("\nВходные данные: ");

            foreach (var v in input)
            {
                logInfo.Append(v).Append(" ");
            }

            string result = AnalaizerClass.RunEstimate();
            logInfo.Append("\nОжидаемый результат: ").Append(expected).Append("\nПолученный результат").Append(result);

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
        public void RunEstimate1()
        {
            RunEstimateTest(1, new ArrayList { "5", "2", "+" }, "7");
        }

        [TestMethod]
        public void RunEstimate2()
        {
            RunEstimateTest(2, new ArrayList { "4", "2", "/", "5", "*" }, "10");
        }

        [TestMethod]
        public void RunEstimate3()
        {
            RunEstimateTest(3, new ArrayList { "3", "4", "2", "+", "*", "1", "-" }, "17");
        }

        [TestMethod]
        public void RunEstimate4()
        {
            RunEstimateTest(4, new ArrayList { "2", "1", "5", "*", "-", "7", "+" }, "4");
        }

        [TestMethod]
        public void RunEstimate5()
        {
            RunEstimateTest(1, new ArrayList { "7", "5", "1", "*", "-", "2", "-", "2", "1", "/", "+" }, "2");
        }
    }
}

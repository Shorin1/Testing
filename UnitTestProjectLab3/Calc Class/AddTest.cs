using System;
using System.Collections;
using BaseCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace UnitTestProject
{
    [TestClass]
    public class Add
    {
        private static Logger logger = LoggingConfiguration();

        private static Logger LoggingConfiguration()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = @"D:\Projects\C#\Shorin1\Testing\UnitTestProjectLab3\bin\Debug\Log.txt" };

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);
            LogManager.Configuration = config;
            Logger logger = LogManager.GetCurrentClassLogger();
            return logger;
        }

        private void AddTest(int numberTest)
        {
            Random ran = new Random();
            long a = ran.Next(int.MaxValue);
            long b = ran.Next(int.MaxValue);
            long result = CalcClass.Add(a, b);
            string logInfo = string.Format("\nNumber test: {0}()\nВходные данные: a = {1}, b = {2}\nОжидаемый результат: {3}\nПолученный результат result = {4}\n", numberTest, a, b, result, result);
            if (a + b >= int.MaxValue)
            {
                logger.Info("\nAdd{0}()\nВходные данные: a = {1}, b = {2}\nОжидаемый результат: {3}\nПолученный результат result = {4}\n", numberTest, a, b, 0, result);
            }
            else if (a + b == result)
            {
                logger.Info(logInfo);
            }
            else
            {
                logger.Error(logInfo);
            }
            
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

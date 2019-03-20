using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using BaseCalculator;
using System.Collections;

namespace UnitTestProject.Analaizer_Class
{
    [TestClass]
    public class CreateStack
    {
        private static Logger logger = LoggingConfiguration();

        private static Logger LoggingConfiguration()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = @"Log\Analaizer Class\CreateStack.txt" };

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);
            LogManager.Configuration = config;
            Logger logger = LogManager.GetCurrentClassLogger();
            return logger;
        }

        private void CreateStackTest(int numbetTest, string input, ArrayList expected)
        {
            AnalaizerClass.expression = input;
            StringBuilder logInfo = new StringBuilder();
            logInfo.Append("\nNumber test: ").Append(numbetTest).Append(" \nВходные данные: ").Append(input).Append(" \nОжидаемый результат: ");

            foreach (var v in expected)
            {
                logInfo.Append(v).Append(" ");
            }

            ArrayList result = AnalaizerClass.CreateStack();

            logInfo.Append(" \nПолученный результат: ");
            LogLevel logLevel = LogLevel.Info;

            for (int i = 0; i < expected.Count; i++)
            {
                logInfo.Append(result[i]).Append(" ");
                Assert.AreEqual(expected[i], result[i]);
                if (!expected[i].Equals(result[i]))
                {
                    logLevel = LogLevel.Error;
                }
            }

            logInfo.Append("\n");
            logger.Log(logLevel, logInfo);
        }

        [TestMethod]
        public void CreateStack1()
        {
            CreateStackTest(1, "5 + 2 ", new ArrayList { "5", "2", "+" });
        }

        [TestMethod]
        public void CreateStack2()
        {
            CreateStackTest(2, "4 / 2 * 5 ", new ArrayList { "4", "2", "/", "5", "*" });
        }

        [TestMethod]
        public void CreateStack3()
        {
            CreateStackTest(3, "3 * ( 4 + 2 ) - 1 ", new ArrayList { "3", "4", "2", "+", "*", "1", "-" });
        }

        [TestMethod]
        public void CreateStack4()
        {
            CreateStackTest(4, "2 - 1 * 5 + 7 ", new ArrayList { "2", "1", "5", "*", "-", "7", "+" });
        }

        [TestMethod]
        public void CreateStack5()
        {
            CreateStackTest(5, "7 - 5 * 1 - 2 + ( 2 / 1 ) ", new ArrayList { "7", "5", "1", "*", "-", "2", "-", "2", "1", "/", "+" });
        }
    }
}

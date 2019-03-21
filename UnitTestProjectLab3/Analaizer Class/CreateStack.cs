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
        private const string COMPONENT_NAME = "AnalaizerClass.CreateStack";
        private const string LOG_FILE_NAME = @"Log\Analaizer Class\CreateStack.txt";

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

        private void CreateStackTest(int testNumber, string input, ArrayList expected)
        {
            AnalaizerClass.expression = input;
            ArrayList result = AnalaizerClass.CreateStack();
            bool successful = true;

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
                if (!result[i].Equals(expected[i]))
                {
                    successful = false;
                }
            }

            if (successful)
            {
                Log.CreateLogInfo(logger, testNumber, input, ListToString(expected), ListToString(result));
            }
            else
            {
                Log.CreateBugReport(logger, COMPONENT_NAME, testNumber, input, ListToString(expected), ListToString(result));
            }
        }

        private string ListToString(ArrayList list)
        {
            StringBuilder result = new StringBuilder();
            foreach (var v in list)
            {
                result.Append(v).Append(" ");
            }
            return result.ToString();
        }

        [TestMethod]
        public void CreateStack1()
        {
            CreateStackTest(1, "5 + 2 ", new ArrayList { "5", "2", "+" });
        }

        [TestMethod]
        public void CreateStack2()
        {
            CreateStackTest(2, "", new ArrayList());
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

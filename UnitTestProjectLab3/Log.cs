using NLog;
using System.Text;

namespace UnitTestProject
{
    static class Log
    {
        public static void CreateLogInfo(Logger logger, int testNumber, string input, string expected, string result)
        {
            string logInfo = string.Format("\nНомер теста: {0}\nВходные данные: {1}\nОжидаемый результат: {2}\nПолученный результат: {3}\n", testNumber, input, expected, result);
            logger.Info(logInfo);
        }

        public static void CreateBugReport(Logger logger, string componentName, int testNumber, string input, string expected, string result)
        {
            StringBuilder bugInfo = new StringBuilder();
            bugInfo.Append("Bug report").Append("\nНомер теста: ").Append(testNumber).Append("\nВходные данные: ").Append(input)
                .Append("\nОжидаемый результат: ").Append(expected).Append("\nПолученный результат: ").Append(result)
                .Append("\nНазвание проекта: BaseCalculator").Append("\nКомпонент: ").Append(componentName).Append("\nНомер версии: 1.0.0")
                .Append("\nСерьезность: ").Append("\nПриоритет: ").Append("\nСтатус: ").Append("\nАвтор репорта: Дмитрий Данилов")
                .Append("\nНазначен на: ").Append("\nОкружение: Windows 10 Pro 17673.379").Append("\nОписание: \n");
            logger.Error(bugInfo);
        }
    }
}

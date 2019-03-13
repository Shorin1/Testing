using System;
using System.Collections;
using BaseCalculator;

namespace Test_Analaizer_Class
{
    class AnalaizerClass_Test
    {
        static void Main(string[] args)
        {
            CheckCurrencyTest();
            FormatTest();
            CreateStackTest();
            RunEstimateTest();
            Console.ReadKey();
        }

        static void CheckCurrencyTest() //Проверка корректности скобочной структуры входного выражения 
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("CheckCurrency()");
                AnalaizerClass.expression = Console.ReadLine();
                if (AnalaizerClass.CheckCurrency()) Console.WriteLine("Скобочная структура верна");
                else Console.WriteLine("Скобочная структура неверна");
            }
        }

        static void FormatTest() //Форматирует входное выражение, выставляя между операторами пробелы и удаляя лишние, а также отлавливает неопознанные операторы, следит за концом строки
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Format()");
                AnalaizerClass.expression = Console.ReadLine();
                Console.WriteLine(AnalaizerClass.Format());
            }
        }

        static ArrayList CreateStackTest() //Создает массив, в котором располагаются операторы и символы, представленные в обратной польской записи(безскобочной) На этом же этапе отлавливаются почти все остальные ошибки (см. код). По сути - это компиляция.
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("CreateStack()");
                AnalaizerClass.expression = Console.ReadLine();
                foreach (var temp in AnalaizerClass.CreateStack()) Console.Write(temp + " ");
                Console.WriteLine();
            }
            return null;
        }

        static void RunEstimateTest() //Вычисление обратной польской записи
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("RunEstimate()");
                ArrayList list = new ArrayList();
                for (int j = 0; j < 3; j++) list.Add(Console.ReadLine());
                AnalaizerClass.opz = list;
                Console.WriteLine(AnalaizerClass.RunEstimate());
            }
        }
    }
}

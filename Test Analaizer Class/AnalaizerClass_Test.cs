using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseCalculator;

namespace Test_Analaizer_Class
{
    class AnalaizerClass_Test
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                CheckCurrencyTest();
                FormatTest();
                CreateStackTest();
                RunEstimateTest();
            }
            Console.ReadKey();
        }

        static void CheckCurrencyTest() //Проверка корректности скобочной структуры входного выражения 
        {
            Console.WriteLine("CheckCurrency()");
            AnalaizerClass.expression = Console.ReadLine();
            bool result = AnalaizerClass.CheckCurrency();
            Console.WriteLine(result);
        }

        static void FormatTest() //Форматирует входное выражение, выставляя между операторами пробелы и удаляя лишние, а также отлавливает неопознанные операторы, следит за концом строки

        {
            Console.WriteLine("Format()");
            AnalaizerClass.expression = Console.ReadLine();
            string result = AnalaizerClass.Format();
            Console.WriteLine(result);
        }

        static ArrayList CreateStackTest() //Создает массив, в котором располагаются операторы и символы, представленные в обратной польской записи(безскобочной) На этом же этапе отлавливаются почти все остальные ошибки (см. код). По сути - это компиляция.
        {
            Console.WriteLine("CreateStack()");
            AnalaizerClass.expression = Console.ReadLine();
            ArrayList result = AnalaizerClass.CreateStack();
            foreach(var temp in result) Console.Write(temp + " ");
            Console.WriteLine();
            return result;
        }

        static void RunEstimateTest() //Вычисление обратной польской записи
        {
            Console.WriteLine("RunEstimate()");
            ArrayList list = new ArrayList();
            for (int i = 0; i < 3; i++) list.Add(Console.ReadLine());
            AnalaizerClass.RunEstimate();
        }
    }
}

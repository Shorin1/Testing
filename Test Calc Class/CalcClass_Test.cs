using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseCalculator;

namespace Testing_tasks
{
    class CalcClass_Test
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            for (int i = 0; i < 3; i++)
            {
                long a = ran.Next(int.MaxValue);
                long b = ran.Next(int.MaxValue);
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                if ((a + b) > int.MaxValue) Console.WriteLine("Ожидаемый результат - слишком большое число");
                else Console.WriteLine("Ожидаемый результат = " + (a + b));

                long result = CalcClass.Add(a, b);
                Console.WriteLine("Полученный результат = " + result);
            }
            Console.ReadKey();
        }
    }
}

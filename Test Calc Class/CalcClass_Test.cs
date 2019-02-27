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
            long a = ran.Next(int.MaxValue);
            long b = ran.Next(int.MaxValue);
            for (int i = 0; i < 3; i++)
            {
                long result = CalcClass.Add(a, b);
                if (result == a + b)
                {
                    Console.WriteLine("a = {0}, b = {1}, a + b = {2}", a, b, a + b);
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("a = {0}, b = {1}, a + b = {2}", a, b, a + b);
                    Console.WriteLine("False");
                }
            }
            Console.ReadKey();
        }
    }
}

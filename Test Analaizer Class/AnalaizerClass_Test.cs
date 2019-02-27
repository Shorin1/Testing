using System;
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

        }

        static void CheckCurrencyTest()
        {
            AnalaizerClass.expression = Console.ReadLine();
            bool result = AnalaizerClass.CheckCurrency();
            Console.WriteLine(result);
        }

        static void FormatTest()
        {
            AnalaizerClass.expression = Console.ReadLine();
            string result = AnalaizerClass.Format();
            Console.WriteLine(result);
        }

        static void CreateStackTest()
        {
            AnalaizerClass.expression = Console.ReadLine();
            var result = AnalaizerClass.CreateStack();
            foreach(var temp in result)
            {
                Console.WriteLine(temp);
            }
        }

        static void RunEstimateTest()
        {
            AnalaizerClass.expression = Console.ReadLine();
            AnalaizerClass.RunEstimate();
            Console.WriteLine(AnalaizerClass.expression);
        }
    }
}

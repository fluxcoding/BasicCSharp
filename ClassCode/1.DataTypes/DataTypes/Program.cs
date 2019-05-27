using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerVariable = 5;
            int integerVariable2;
            integerVariable2 = -100;
            integerVariable = 12;
            float floatVariable = 2.5F;
            double doubleVariable = 2.5;
            string stringVariable = "Hello world";
            char charVariable = '^';
            bool booleanVariable = true;


            int sumOfTwoNumbers = 2 + 6;
            sumOfTwoNumbers += 12;
            sumOfTwoNumbers++;

            bool isLarger = 6 > 12;


            bool someExpresion = true;

            someExpresion &= isLarger;



            // Console.WriteLine(integerVariable);
            // Console.WriteLine(integerVariable2);
            // Console.WriteLine(stringVariable);
            Console.Write(sumOfTwoNumbers);
            Console.Read();
            

        }
    }
}

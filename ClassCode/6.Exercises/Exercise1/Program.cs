using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void NumberStats()
        {
            Console.WriteLine("Enter a number: ");
            double num = double.Parse(Console.ReadLine());

            string a;
            string b;
            string c;


            if (num>0)
            {
                a = "Positive";
            }
            else
            {
                a = "Negative";
            }

            if (num %2 == 0)
            {
                b = "Even";
            } else
            {
                b = "Odd";
            }

            if (num %1 == 0)
            {
                c = "Integer";
            }
            else
            {
                c =  "Decimal";
            }

            Console.WriteLine($"Stats for number : {num} \n {a} \n {b} \n {c}");

        }



        static void Main(string[] args)
        {
            NumberStats();
            
            Console.ReadLine();
        }
    }
}

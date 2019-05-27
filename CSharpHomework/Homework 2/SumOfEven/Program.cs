using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niza = new int[6];

            while (true)
            {

            

            for (int i = 0; i < niza.Length; i++)
            {
                Console.WriteLine($"Enter integer no.{i + 1}");

                int ifParsed;
                bool parsYesorNo = int.TryParse(Console.ReadLine(), out ifParsed);

                if (parsYesorNo == true)
                {
                    niza[i] = ifParsed;

                } else
                {
                    Console.WriteLine("You did not enter a number! Try again: ");
                    i = i - 1;
                }

            }

            int sumOfEven = 0;

            foreach (int broj in niza)
            {
                if (broj % 2 == 0)
                {
                    sumOfEven += broj;
                }
            };


            Console.WriteLine($"The result is: {sumOfEven}");
            Console.WriteLine("---------------------------------");

        }
            Console.ReadLine();

        }
    }
}

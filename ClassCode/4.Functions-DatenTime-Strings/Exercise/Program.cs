using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Substract(int a, int b)
        {
            return a - b;
        }


        static void Main(string[] args)
        {
            #region Exercise 1


            while (true)
            {
                Console.WriteLine("Select what to do: + or - ");
                string operation = Console.ReadLine();

                Console.WriteLine("Enter two numbers to do the operation:");

                Console.WriteLine("First number:");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Second number:");
                int b = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case "+":
                        Console.WriteLine("The result is " + Sum(a, b));
                        Console.WriteLine("--------------------");
                            break;
                    case "-":
                        Console.WriteLine("The result is " + Substract(a, b));
                        Console.WriteLine("--------------------");
                        break;
                    default:
                        break;
                }

                #endregion

                Console.ReadLine();
            }

         



        }
    }
}

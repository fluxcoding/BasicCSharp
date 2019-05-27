using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Task 1

            while (true)
            {

                int ifItsNum1;
                int ifItsNum2;

                Console.WriteLine("Please enter First number");
                

                bool parsSucc1 = int.TryParse(Console.ReadLine(), out ifItsNum1);

                Console.WriteLine("Please enter Second number");
                

                bool parsSucc2 = int.TryParse(Console.ReadLine(), out ifItsNum2);

                if (parsSucc1 == true && parsSucc2 == true)
                {

                Console.WriteLine("Which operation would you like to use? ( +, - , * , / )");
                    var operation = Console.ReadLine();


                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                    {
                        switch (operation)
                        {
                            case "+":
                                Console.WriteLine("The result is: " + (ifItsNum1 + ifItsNum2));
                                Console.WriteLine("------------------------------------------");
                                break;
                            case "-":
                                Console.WriteLine("The result is: " + (ifItsNum1 - ifItsNum2));
                                Console.WriteLine("------------------------------------------");
                                break;
                            case "*":
                                Console.WriteLine("The result is: " + (ifItsNum1 * ifItsNum2));
                                Console.WriteLine("------------------------------------------");
                                break;
                            case "/":
                                Console.WriteLine("The result is: " + (ifItsNum1 / ifItsNum2));
                                Console.WriteLine("------------------------------------------");
                                break;
                            default:
                                break;
                        }
                    }
                    
                    else
                    {
                        Console.WriteLine("Please enter one of the following operations:( +, - , * , / )");

                    }
                }
                else
                {
                    Console.WriteLine("You entered invalid number or numbers");

                };



            };

            #endregion

            Console.ReadLine();
        }
    }
}

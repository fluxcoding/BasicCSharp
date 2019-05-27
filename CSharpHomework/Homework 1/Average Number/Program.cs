using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 2

            while (true)
            {

                int ifNum1;
                int ifNum2;
                int ifNum3;
                int ifNum4;

                Console.WriteLine("Please enter Four numbers:");
                bool parsS1 = int.TryParse(Console.ReadLine(), out ifNum1);
                bool parsS2 = int.TryParse(Console.ReadLine(), out ifNum2);
                bool parsS3 = int.TryParse(Console.ReadLine(), out ifNum3);
                bool parsS4 = int.TryParse(Console.ReadLine(), out ifNum4);

                if (parsS1 == true && parsS2 == true && parsS3 == true && parsS4 == true)
                {

                double averageOf = Convert.ToDouble((ifNum1 + ifNum2 + ifNum3 + ifNum4) / 4.0);
                  

                    Console.WriteLine("The average of " + ifNum1 + ", " + ifNum2 + ", " + + ifNum3 + ", " + +ifNum4 +  " is " + averageOf);
                    Console.WriteLine("------------------------------------");
                }
                else
                {
                    Console.WriteLine("You did not enter numbers");
                    Console.WriteLine("------------------------------------");
                }
               
            };

            #endregion
        }
    }
}

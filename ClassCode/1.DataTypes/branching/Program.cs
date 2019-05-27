using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int m = 5;

            // var drva = int.Parse(Console.ReadLine());

            //int allApplesPerTree = 12 * n;

            //int siteDrva = drva * allApplesPerTree;

            //int howManyBaskets = siteDrva / m;

            // Console.WriteLine(howManyBaskets);


            //var firstNumber = int.Parse(Console.ReadLine());
            //var secondNumber = int.Parse(Console.ReadLine());

            //int larger;


            //if (firstNumber > secondNumber)
            //{
            //    Console.WriteLine("First number is larger");

            //    larger = firstNumber;

            //} else
            //{
            //    Console.WriteLine("Second number is larger");

            //    larger = secondNumber;
            //};

            //if (larger %2 == 0){
            //    Console.WriteLine("The number is even");
            //} else
            //{
            //    Console.WriteLine("The number is odd");
            //}


            //if (num1 > num2)
            //{
            //    Console.WriteLine("The first number is larger!");
            //} else if (num2 > num1)
            //{
            //    Console.WriteLine("The second number is larger");
            //} else
            //{
            //    Console.WriteLine("They are same");
            //};

            Console.WriteLine("Enter a number: ");
            var enterNumber = int.Parse(Console.ReadLine());


            

            switch (enterNumber)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;

                default:
                    break;
            }






            Console.ReadLine();
        }
    }
}

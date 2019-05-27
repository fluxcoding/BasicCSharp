using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            #region For loop


            //for (int i = 0; i <= 5; i++)
            //{

            //    Console.WriteLine(i);
            //    string word = Console.ReadLine();
            //    Console.WriteLine("Your word was:" + word);

            //}

            //Console.WriteLine("Creating a droid army");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Assembling droid number:" + i);
            //    if (i == 7)
            //    {
            //        Console.WriteLine("this droid is broken!");
            //        continue;

            //    }
            //    if (i == 9)
            //    {
            //        Console.WriteLine("Machine broke down!");
            //        break;
            //    }
            //    Console.WriteLine("Droid " + i + " Created!");
            //}
            #endregion

            #region while loop

            //int counter = 0;
            //while (counter <= 5)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}

            //Console.WriteLine("Press X to close the application");
            //while (Console.ReadLine() != "x")
            //{
            //    Console.WriteLine("Write number 1: ");
            //    int number1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Write number 2: ");
            //    int number2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Result:" + (number1 + number2));
            //}

            #endregion

            #region Do While Loop

            //int counter2 = 0;
            //do
            //{
            //    Console.WriteLine(counter2);
            //    counter2++;
            //} while (counter2 <=5);
            #endregion

            #region Ex 1
            //Console.WriteLine("Enter random number: ");

            //int counter = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= counter; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Enter random number again: ");

            //int counter2 = int.Parse(Console.ReadLine());
            //for (int i = counter2; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Ex 2

            //Console.WriteLine("Enter a number:");
            //int counter = int.Parse(Console.ReadLine());



            //for (int i = 2; i < counter; i++)
            //{
            //    if (i %2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //};

            //Console.WriteLine("Enter a second number:");

            //int counter2 = int.Parse(Console.ReadLine());

            //for (int i = 1; i < counter; i++)
            //{
            //    if (i %2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //};


            #endregion

            #region Ex3
            //Console.WriteLine("Enter a number");
            //int counter = int.Parse(Console.ReadLine());
            //int cnt = 1;

            //while (cnt != counter)
            //{

            //    if (cnt % 2 == 3 || cnt % 2 == 7)
            //    {
            //        Console.WriteLine(cnt);


            //    }
            //    else if (cnt == 100)

            //    {
            //        Console.WriteLine("The limit is reached");
            //        break;
            //    }
            //    Console.WriteLine("Hey");
            //    cnt++;
            //}


            #endregion


            Console.Read();
        }
    }
}

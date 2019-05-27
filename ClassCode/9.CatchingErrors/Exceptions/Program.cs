using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please write a number:");
            //int number = 0;

            // Try catch without exception

            //try
            //{
            //    number = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"The number is {number}!");
            //}
            //catch
            //{
            //    Console.WriteLine("There was an error.Please contact Borche.");
            //    Console.WriteLine("+38970999999");
            //}




            //try
            //{
            //    number = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"The number is {number}!");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"There was an error. {ex.Message}");
            //    Console.WriteLine("Please contact Borche");
            //    Console.WriteLine("+38970999999");
            //}
            //finally
            //{
            //    Console.WriteLine("Application is done.You can drink a coffee now!");
            //}

            Console.WriteLine("Please enter a or b");
            char letter = ' ';


            try
            {
               letter = char.Parse(Console.ReadLine());

                if (letter != 'a' && letter != 'b')
                {
                    throw new Exception("That was not a or b! You broke the app");
                }
                Console.WriteLine("Congratz!!!!!!!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ova e FORMAT EKSPESHN! UTKA U FORMAT!");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"There was an error: {ex.Message}");
                Console.WriteLine("Please contact support.");
                // conde that sends email to support
            }



           

                Console.ReadLine();
        }
    }
}

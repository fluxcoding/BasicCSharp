using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Enter two numbers that you want to swap!");

                Console.WriteLine("Input the first number: ");
                int FirstNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Input the second number: ");
                int SecondNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Before swap: first number = " + FirstNum);
                Console.WriteLine("Before swap: second number = " + SecondNum);
                Console.WriteLine(" ");

               
               
                FirstNum = FirstNum + SecondNum;
                SecondNum = FirstNum - SecondNum;
                FirstNum = FirstNum - SecondNum;
                // a = 5  b = 10
                // 5 = 5 + 10    = [15]
                // 10 = 15 - 5   =  [5]
                // 15 = 15 - 5   = [10]


                Console.WriteLine("After swap: first number = " + FirstNum);
                Console.WriteLine("After swap: second number = " + SecondNum);
                Console.WriteLine("---------------------------------------");

            }
        }
    }
}

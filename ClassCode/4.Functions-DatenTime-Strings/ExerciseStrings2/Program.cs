using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseStrings2
{
    class Program
    {

    static void Substrings(int sec)
        {
            string Format =  "Hello from SEDC Codeacademy v7.0";
            string newFormat = Format.Substring(0,sec);
            Console.WriteLine(newFormat);
            Console.WriteLine(newFormat.Length);
            
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            Substrings(num);



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Function
{
    class Program
    {

        // tuka pisuvame metodi

        static void CheckDroid1()
        {
            Console.WriteLine("These arent the droids you are looking for.");
            Console.ReadLine();
        }

        static string CheckDroid2()
        {
            return "This is the droid";
        }

        static string JediMind()
        {
            return "This is the message if the if is true";
        }

        static string CheckDroid3(bool jedi)
        {
            if (jedi)
            {
                return JediMind();
            }

            return "Message in chase the if fails";
        }


        static void Main(string[] args)
        {

            //            CheckDroid1();
            // Console.WriteLine(CheckDroid2());

            Console.WriteLine(CheckDroid3(true));




            Console.ReadLine();
        }
    }
}

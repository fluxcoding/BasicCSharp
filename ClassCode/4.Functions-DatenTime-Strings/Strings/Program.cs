using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "bob";
            string name2 = "swarovski";
            string hello = "Hello" + name;


            //string hello2 = string.Format("Hello {0} and {1}", name,name2);
            //Console.WriteLine(hello2);

            //string hello3 = $"Hello {name} and {name2}";
            //Console.WriteLine(hello3);


            string string1 = string.Format("Hello {0:c}", 25);
            string string2 = string.Format("Hello {0:p}", 0.5);
            string string3 = string.Format("Hello {0:0##-###-###}", 070993854);

            //Console.WriteLine(string1);
            //Console.WriteLine(string2);
            //Console.WriteLine(string3);

            string string4 = string.Format("{0,10} {1,15}", "id", "Product");
            string string5 = string.Format("{0,10} {1,15}", "123", "Phone");
            string string6 = string.Format("{0,10} {1,15}", "124", "TV");


            Console.WriteLine(string4);
            Console.WriteLine(string5);
            Console.WriteLine(string6);
            


            Console.ReadLine();
        }
    }
}

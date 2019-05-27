using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void FindDude(string person,Dictionary<string,int> phonebook)
        {
            if (phonebook.ContainsKey(person))
            {
                Console.WriteLine("Hello " + person  + "your number is " + phonebook[person]);
            }
            else
            {
                Console.WriteLine("There is no such a user");
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            Dictionary<string, int> PhoneBook = new Dictionary<string, int>()
            {
                {"Teodor",070000111},
                {"Stefan",070000222},
                {"Dejan",070000333},
                {"Toni",070000444},
                {"Bobi",070000555},

            };

            Console.WriteLine("Enter a name:");
            var x = Console.ReadLine();

            FindDude(x, PhoneBook);
            
        }

        
        
    }
}

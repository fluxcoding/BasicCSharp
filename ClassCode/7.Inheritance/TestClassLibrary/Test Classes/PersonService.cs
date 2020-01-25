using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Test_Classes
{
    public class PersonService
    {

        public void PrintAnyPerson(Person person)
        {
            Console.WriteLine($"ID:{person.Id}, Name:{person.Name}");
            // Vidi kako se konektirani
        }

    }
}

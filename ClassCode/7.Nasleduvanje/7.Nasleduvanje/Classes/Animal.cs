using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Nasleduvanje.Classes
{
    public class Animal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Tip Type { get; set; }

       
        public Animal()
        {
            Console.WriteLine("An animal object is beeing constructed!");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"The animal {Name} is eating!");
        }

        public void PrintInfo()
        {
            Console.WriteLine("------- Animal Info -------");
            Console.WriteLine($"ID:{Id}");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Type:{Type}");
        }
    }

}

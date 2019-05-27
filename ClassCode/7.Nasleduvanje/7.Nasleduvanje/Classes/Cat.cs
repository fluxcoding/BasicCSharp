using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Nasleduvanje.Classes
{
    public class Cat  : Animal
    {
        public int Lazyness { get; set; }

        public override void Eat()
        {
            Console.WriteLine("You don't tell a cat when to eat. Cat eats when it wants!");
        }

        public Cat()
        {
            Console.WriteLine("An object Cat is beeing created!");
            Type = Tip.Cat;
        }

        public void Meow()
        {
            Console.WriteLine("Meow Meow!");
        }
    }
}

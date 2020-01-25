using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Nasleduvanje.Classes
{
    public class Dog : Animal
    {

        public string Race { get; set; }

        public Dog()
        {
            Console.WriteLine("A dog object is being created!");
            Type = Tip.Dog;
        }


        public void Bark()
        {
            Console.WriteLine("Bark Bark!");
            
        }
    }

}

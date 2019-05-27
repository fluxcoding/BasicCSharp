using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Dog
    {
        public string Name { get; set; }

        public string Race { get; set; }

        public string Color { get; set; }


        public string Eat()
        {
            return "The dog is now eating";
        }

        public string Play()
        {
            return "The dog is now playing";
        }

        public string ChaseTail()
        {
            return "The dog is now chasing a tail";
        }



        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your pet name:");
            string name = Console.ReadLine();
            Console.WriteLine("What race is your pet:");
            string race = Console.ReadLine();
            Console.WriteLine("What color is it:");
            string color = Console.ReadLine();


            Dog Max = new Dog(name,race,color);

            Console.WriteLine("What would you like ur pet to do?");
            Console.WriteLine("Eat/Play/ChaseTail?");
            string Selected = Console.ReadLine();

            switch (Selected)
            {
                case "Eat":
                    Console.WriteLine(Max.Eat());
                    break;
                case "Play":
                    Console.WriteLine(Max.Play());
                    break;
                case "ChaseTail":
                    Console.WriteLine(Max.ChaseTail());
                    break;
                default:
                    Console.WriteLine("Please enter valid option");
                    break;
            }

            Console.ReadLine();

        }
    }
}


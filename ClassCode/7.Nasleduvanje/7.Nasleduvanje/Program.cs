using _7.Nasleduvanje.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary.Test_Classes;

namespace _7.Nasleduvanje
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonService personService = new PersonService();


            Animal frogger = new Animal() { Id = 5, Name = "Frogger", Type = Tip.Frog };

            frogger.Eat();
            frogger.PrintInfo();

          Console.Clear();

            Dog spark = new Dog() { Id = 2, Name = "Spark", Race = "Dzukelce" };

            spark.Eat();
            spark.PrintInfo();


            Console.Clear();

            Cat wiskers = new Cat() {Id = 7, Name = "Wiskers", Lazyness = 9};

            wiskers.Eat();

            wiskers.PrintInfo();

            wiskers.Meow();

            Console.Clear();

            //            var someType = Tip.Cat;

            Person bob = new Person() { Id = 3, Name = "Bob", Role = "Developer" };
            personService.PrintAnyPerson(bob);

            Console.ReadLine();

        }
    }
}

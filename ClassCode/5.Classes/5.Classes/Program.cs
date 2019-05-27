using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _5.Classes
{
    class Person
    {
        // Properties
        //  <Acc.mod><Type><name><getter and setter>
        public string Name { get; set; }

        public int Age { get; set; }

        //public Address Address

        // COnstructor

        public Person()
        {
            Console.WriteLine("Constructing person");
            //dejan.Address = new Address();
            Name = "Petko";
            Age = 25;
        }


        public Person (string name, int age)
        {
            Console.WriteLine("The other constructor is constructiong a Person!");
            //dejan.Address = new Address();
            Name = name;
            Age = age;
        }

        //Methods

        public void PrintPerson()
        {
            Console.WriteLine($"Name:{Name},Age:{Age}");
        }

    }


    class Program
    {

        // METODI
        static void Main(string[] args)
        {
            //KOD

            Person dejan = new Person();
            dejan.Name = "Dejan";
            dejan.Age = 19;
          //  dejan.Address = new Address();
            dejan.Address.Name = "Narodni heroi";
            dejan.Address.Number = 24;
            dejan.PrintPerson();


            Person dragan = new Person()
            {
                Name = "dragan",
                Age = 55
            };

            dragan.PrintPerson();

            Person randomperson = new Person();
            randomperson.Name = "sup";

            randomperson.PrintPerson();

            // Vtoriot nov konkstruktor

            Person Bob = new Person("bob", 67);

            Bob.PrintPerson();


            Console.ReadLine();

        }
    }

}

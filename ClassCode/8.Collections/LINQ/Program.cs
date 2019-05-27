using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }


    }


    class Program
    {
        static void Main(string[] args)
        {

            List<Dog> dogs = new List<Dog>
            {
                new Dog(){Name = "Sparky", Age = 2},
                new Dog(){Name = "Lois", Age = 3},
                new Dog(){Name = "Moli", Age = 2},
                new Dog(){Name = "Mimi", Age = 1},
                new Dog(){Name = "Shark", Age = 5},
                new Dog(){Name = "Dicky", Age = 6},
                new Dog(){Name = "Mufo", Age = 3},
            };

            var olderThan2 = dogs.Where(x => x.Age > 2).ToList();
            var nameWithB = dogs.Where(x => x.Name.StartsWith("B")).ToList();

            //foreach (Dog dog in nameWithB)
            //{
            //    Console.WriteLine(dog.Name);
            //}

            // Console.WriteLine(olderThan2.First().Name);

            //   Console.WriteLine(olderThan2.Where(x=> x.Name.StartsWith("T")).FirstOrDefault());
            // da ne frla error ako ne najde takvo i da prekine programata


            var namesOfDogs = dogs.Select(x => x.Name).ToList();

            var specialDog = dogs.Where(x => x.Name.StartsWith("M"))
                .Where(x => x.Age == 1)
                .Select(x => x.Name)
                .FirstOrDefault();

            Console.WriteLine(specialDog);


            //foreach (var item in namesOfDogs)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();


        }
    }
}

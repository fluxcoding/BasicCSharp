using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework3.Classes;

namespace Homework3
{
    class Program
    {
        static void RaceCars(Car one, Car two)
        {
            if (one.CalculateSpeed(one.Driver) > two.CalculateSpeed(two.Driver))
            {
                Console.WriteLine($"Car 1 was faster.\n Model: { one.Model} \n speed: { one.CalculateSpeed(one.Driver)} \n driver: { one.Driver.Name}");
            } else
            {
                Console.WriteLine($"Car 2 was faster.\n Model: { two.Model} \n speed: { two.CalculateSpeed(one.Driver)} \n driver: { two.Driver.Name}");
            }
        }

        static void Main(string[] args)
        {

            Driver bob = new Driver("Bob", 10);
            Driver greg = new Driver("Greg", 15);
            Driver jill = new Driver("Jill", 5);
            Driver anne = new Driver("Anne", 20);

            Car hyundai = new Car("Hyundai", 280);
            Car mazda = new Car("Mazda", 360);
            Car ferrari = new Car("Ferrari", 240);
            Car porche = new Car("Porsche", 200);

            Driver driver1;
            Driver driver2;

            Car car1;
            Car car2;

            bool x = true;

            while (x)
            {

                Console.WriteLine($"Choose a car no.1: \n 1) Hyundai \n 2) Mazda \n 3) Ferrari \n 4) Porsche");

                var carOne = Console.ReadLine();

                Console.WriteLine($"Choose Driver: \n 1) Bob \n 2) Greg \n 3) Jill \n 4) Anne");

                var driverOne = Console.ReadLine();

                Console.WriteLine("--------------------");

                Console.WriteLine($"Choose a car no.2: \n 1) Hyundai \n 2) Mazda \n 3) Ferrari \n 4) Porsche");

                var carTwo = Console.ReadLine();

                Console.WriteLine($"Choose Driver: \n 1) Bob \n 2) Greg \n 3) Jill \n 4) Anne");

                var driverTwo = Console.ReadLine();

                switch (carOne)
                {
                    case "1":
                        car1 = hyundai;
                        break;
                    case "2":
                        car1 = mazda;
                        break;
                    case "3":
                        car1 = ferrari;
                        break;
                    case "4":
                        car1 = porche;
                        break;
                    default:
                        car1 = null;
                        break;
                }

                switch (carTwo)
                {
                    case "1":
                        car2 = hyundai;
                        break;
                    case "2":
                        car2 = mazda;
                        break;
                    case "3":
                        car2 = ferrari;
                        break;
                    case "4":
                        car2 = porche;
                        break;
                    default:
                        car2 = null;
                        break;
                }

                switch (driverOne)
                {
                    case "1":
                        driver1 = bob;
                        break;
                    case "2":
                        driver1 = greg;
                        break;
                    case "3":
                        driver1 = jill;
                        break;
                    case "4":
                        driver1 = anne;
                        break;
                    default:
                        driver1 = null;
                        break;
                }

                switch (driverTwo)
                {
                    case "1":
                        driver2 = bob;
                        break;
                    case "2":
                        driver2 = greg;
                        break;
                    case "3":
                        driver2 = jill;
                        break;
                    case "4":
                        driver2 = anne;
                        break;
                    default:
                        driver2 = null;
                        break;
                };


                car1.Driver = driver1;
                car2.Driver = driver2;


                RaceCars(car1, car2);
                Console.WriteLine("------------------------------------------ \n------------------------------------------");

                Console.WriteLine("Would you like to race again? Y / N");
                var y = Console.ReadLine();

                if (y == "N" || y == "n")
                {
                    x = false;
                }

            }
         

        }
    }
}

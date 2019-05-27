using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void ProcessCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }


        static void Main(string[] args)
        {
            

            #region List


            // List

            //array 
            //   string[] peoples = new string[3];
            //   peoples[0] = "Bob";

            List<string> people = new List<string>();

            people.Add("Jill");

          //  people[0] = "Bob";  // Ova ne // go overwrita jill

            people.Add("Sam"); // Yes
            people.Add("bob");
           
            people.Remove("bob");

            var test = people.Find(x => x == "Jill");
            Console.WriteLine(test);
            Console.WriteLine(people.Count);

            Console.WriteLine("--------");



            List<int> numbers = new List<int>() {2,3,4,567,4,2};

          //  Console.WriteLine(numbers[3]); go printa '567'

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //};

          // numbers.Lenght ne koristime , koristime numbers.Count

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //};


            List<List<int>> listaVoLista = new List<List<int>>();
            listaVoLista.Add(new List<int>() { 1, 2, 3, 4 });

            Console.WriteLine(listaVoLista[0][0]);
            // go dobivame 1


            #endregion


            #region Dictionary

            Dictionary<int, string> produkti = new Dictionary<int, string>();

            produkti.Add(5, "Ajvar");
            produkti.Add(10, "Cheese Burger");

            foreach (var item in produkti)
            {
                Console.WriteLine(item);
              //  Console.WriteLine(item.Key);
              //  Console.WriteLine(item.Value);
            }

            Console.WriteLine(produkti.ContainsValue("Ajvar"));
            Console.WriteLine(produkti.ContainsKey(5));


            //  Console.WriteLine(produkti[5]);
            //  Ajvar

            // Kreirame direktno dictionary so itemi
            Dictionary<string, bool> groceryList = new Dictionary<string, bool>()
            {
                {"Kompir",false },
                {"Puter",true },
                {"Sol",false }
            };

            Console.WriteLine("-----------");

            #endregion


            #region Queue

            Queue<string> names = new Queue<string>();

            names.Enqueue("Bob");
            names.Enqueue("Greg");
            names.Enqueue("Dragisha");

            Console.WriteLine(names.Count);


            Console.WriteLine(names.Peek());
            // So ova go gledame koj e na red za dequeue


            string takenOut = names.Dequeue();
            Console.WriteLine(takenOut);

            Console.WriteLine(names.Count);

            string takenout2 = names.Dequeue();
            Console.WriteLine(takenout2);

            Console.WriteLine(names.Count);

            names.Enqueue("Dejanisha");

            string takenout3 = names.Dequeue();
            Console.WriteLine(takenout3);

            Console.WriteLine("----------------");

            #endregion


            #region Stack

            Stack<int> numberz = new Stack<int>();

            numberz.Push(5);
            numberz.Push(12);
            numberz.Push(-500);

            Console.WriteLine(numberz.Count());

            int takenout01 = numberz.Pop();
            Console.WriteLine(takenout01);

            numberz.Push(0);

            Console.WriteLine(numberz.Count());

            int takenout02 = numberz.Pop();
            Console.WriteLine(takenout02);

            Console.WriteLine(numberz.Peek());


            #endregion

            Console.ReadLine();
        }
    }
}

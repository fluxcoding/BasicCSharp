using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise2.Klasi;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // user e koj vid podatoci ke drzi arrayto / vaka se pravat anonimni objekti
            User[] users = 
                // user[] users = new User[]
            {
                new User(1,"Teodor", "thebest", new string[]{"Welcome","Godmode","Earth"}),
                new User(2,"Arrow","sucks", new string[]{"First","Second","thirth"}),
                new User(3,"Captain","feminism", new string[]{"Worst","Movie","Ever"})
            };

            while (true)
            {

            

            Console.WriteLine("Would you like to: \n 1.LogIn \n 2.Register");
            string option = Console.ReadLine();

                Console.WriteLine("-------------");
                //Login
                if (option == "1")
            {

                Console.WriteLine("Enter your username");
                string x = Console.ReadLine();

                Console.WriteLine("Enter your password");
                string y = Console.ReadLine();


                    Console.WriteLine("----------------------------------");

                    User exUser = null;

                
                foreach (var currentUser in users)
                {
                    if (x == currentUser.Username && y == currentUser.Password)
                    {
                        exUser = currentUser;
                        break;

                    }
                }

                if(exUser == null)
                {
                    Console.WriteLine("You entered wrong username or password!");
                } else
                {
                    Console.WriteLine($"Welcome {exUser.Username}. Here are your messages: \n {exUser.Messages[0]}\n {exUser.Messages[1]}");
                }
                    Console.WriteLine("----------------------------------");
                }
            // Register
            else if (option == "2")
            {
                Console.WriteLine("Enter ID");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Username");
                var b = Console.ReadLine();
                Console.WriteLine("Enter Password");
                var c = Console.ReadLine();

                    Console.WriteLine("----------------------------------");
                    string goIma = null;

                foreach (var lugje in users)
                {
                    if (lugje.Username == b)
                    {
                        goIma = lugje.Username;
                        break;
                    }
                }


                if (goIma == null)
                {
                    // Kreirame objekt i go turkame

                    Array.Resize(ref users, users.Length + 1);

                    users[users.Length - 1] = new User(a, b, c, new string[] { "Worst", "Movie", "Ever" });

                    Console.WriteLine("Registration completed");
                        Console.WriteLine("List of users:");

                    foreach (var dude in users)
                    {
                        Console.WriteLine(dude.Id + " " + dude.Username);
                    }

                        Console.WriteLine("----------------------------------");

                    // end of objekt
                }
                else
                {
                    Console.WriteLine("The username is already taken!");
                }


            }
            else
            {
                Console.WriteLine("You did not select any of the options above.");
            }

            }

            Console.ReadLine();
        }
    }
}

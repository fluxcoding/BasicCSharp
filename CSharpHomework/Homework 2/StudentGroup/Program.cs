using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
            string[] studentsG2 = new string[] { "Darko", "Marko", "Zarko", "Stefan", "Petar" };

            while (true)
            {
                Console.WriteLine("Enter student group: ( there are 1 and 2 )");
                int izbor = int.Parse(Console.ReadLine());

                string Output = $"The Students in G{izbor} are:\n";

                if (izbor == 1 || izbor == 2)
                {

                    switch (izbor)
                    {
                        case 1:
                            foreach (string name in studentsG1)
                            {

                                Output += name + '\n';
                            }
                            Console.WriteLine(Output);
                            break;

                        case 2:
                            foreach (string name in studentsG2)
                            {

                                Output += name + '\n';
                            }
                            Console.WriteLine(Output);
                            break;
                        default:
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("You entered invalid student group number!");
                }

            }

           
            
        }
    }
}

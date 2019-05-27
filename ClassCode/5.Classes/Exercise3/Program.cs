using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Student
    {
        public string Name { get; set; }

        public string Academy { get; set; }

        public string Group { get; set; }


        public string Info()
        {
            return $"{Name} from {Academy} is in group {Group}";
        }



        public Student(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;

        }

    }



        class Program
    {
        static void Main(string[] args)
        {

            Student One = new Student("Stefan","SEDC","Five");
            Student Two = new Student("Nikola", "SEDC", "Five");
            Student Three = new Student("Marko", "SEDC", "Five");
            Student Four = new Student("Kiko", "SEDC", "Five");
            Student Five = new Student("Dejan", "SEDC", "Five");

            Console.WriteLine();

            double asd = 0.4;

            Student[] students = new Student[] {One,Two,Three,Four,Five};


            Console.WriteLine("Which student would you like to search for? ");

            string nameToSearch = Console.ReadLine();

            // sea da barame niz Arrayto Students dali se poklopuva

            // napravi gi site elementi so mali bukvi od nizata 



            Console.ReadLine();

        }
    }
}

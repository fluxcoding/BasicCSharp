using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademyManagement.Classes;

namespace AcademyManagement
{
    class Program
    {
        #region Removing

        //public static void RemoveAdmin(string name, List<Admin> Admins, Admin currentAdmin)
        //{
        //    bool remove = false;

        //    foreach (var admin in Admins)
        //    {
        //        if (name == admin.Username && !(name == currentAdmin.Username))
        //        {
        //            remove = true;
        //            Admins.Remove(admin);
        //            break;
        //        }
        //    }
        //    if ((!remove)&&(name != currentAdmin.Username))
        //    { Console.WriteLine("There is no such a Name"); }
        //    if ((!remove)&&(name == currentAdmin.Username))
        //    {Console.WriteLine("You can't remove yourself! :)"); }

        //}

        #endregion

        static void Main(string[] args)
        {
            
            
            #region AddingClasses

            List<Admin>Admins = new List<Admin>();
            List<Trainer>Trainers = new List<Trainer>();
            List<Student>Students = new List<Student>();

            
            Admins.Add(new Admin("Teodor","password"));
            Admins.Add(new Admin("Stefan", "password"));

            Trainers.Add(new Trainer("Nikola", "password"));
            Trainers.Add(new Trainer("Nina", "password"));
            Trainers.Add(new Trainer("Dragan", "password"));
            Trainers.Add(new Trainer("Toshe", "password"));

            Students.Add(new Student("Kiko", "password"));
            Students.Add(new Student("Ivan", "password"));
            Students.Add(new Student("Bojan", "password"));
            Students.Add(new Student("Stefanija", "password"));
            Students.Add(new Student("Dea", "password"));

            #endregion


                Console.WriteLine("Select your role: ");
                Console.WriteLine("1.Admin \n2.Trainer \n3.Student");
                int role = int.Parse(Console.ReadLine());

                Admin currentAdmin = null;
                Trainer currentTrainer = null;
                Student currentStudent = null;

         

            #region switch
            switch (role)
                {
                    case 1:
                    Console.WriteLine("You logged in as Admin");
                        bool x = true;
                        while (x)
                        {
                        // START
                        Console.WriteLine("Please enter your username:");
                        string user = Console.ReadLine();
                        Console.WriteLine("Please enter your password:");
                        string pass = Console.ReadLine();
                        //
                        bool found = true;

                        foreach (Admin admin in Admins)
                        {
                            if (admin.Username == user && admin.Password == pass)
                            {
                                currentAdmin = admin;
                                found = true;
                                break;
                            }
                            else
                            {found = false;}
                        }

                        if (found == true)
                        {
                            Console.WriteLine("****************");
                            Console.WriteLine($"Welcome {currentAdmin.Username}!");
                            Console.WriteLine("****************");
                            x = false;
                        } else
                        {
                            Console.WriteLine("Wrong username and password!");
                            Console.WriteLine("Do you want to try again? Y/N");
                            var opt = Console.ReadLine();
                            if (opt == "n")
                            {
                                x = false;
                            }
                        }
                        
                        // END
                    }
                        break;

                        case 2:
                    Console.WriteLine("You logged in as Trainer");
                    bool y = true;
                        while (y)
                        {
                        // START
                        Console.WriteLine("Please enter your username:");
                        string user = Console.ReadLine();
                        Console.WriteLine("Please enter your password:");
                        string pass = Console.ReadLine();
                        //
                        bool found = true;

                        foreach (Trainer trainer in Trainers)
                        {
                            if (trainer.Username == user && trainer.Password == pass)
                            {
                                currentTrainer = trainer;
                                found = true;
                                break;
                            }
                            else
                            { found = false; }
                        }

                        if (found == true)
                        {
                            Console.WriteLine("****************");
                            Console.WriteLine($"Welcome {currentTrainer.Username}!");
                            Console.WriteLine("****************");
                            y = false;
                        }
                        else
                        {
                            Console.WriteLine("Wrong username and password!");
                            Console.WriteLine("Do you want to try again? Y/N");
                            var opt = Console.ReadLine();
                            if (opt == "n")
                            {
                                y = false;
                            }
                        }

                        // END

                    }
                    break;

                    case 3:
                    Console.WriteLine("You logged in as Student");
                    bool z = true;
                        while (z)
                        {
                        // START
                        Console.WriteLine("Please enter your username:");
                        string user = Console.ReadLine();
                        Console.WriteLine("Please enter your password:");
                        string pass = Console.ReadLine();
                        //
                        bool found = true;

                        foreach (Student student in Students)
                        {
                            if (student.Username == user && student.Password == pass)
                            {
                                currentStudent = student;
                                found = true;
                                break;
                            }
                            else
                            { found = false; }
                        }

                        if (found == true)
                        {
                            Console.WriteLine("****************");
                            Console.WriteLine($"Welcome {currentStudent.Username}!");
                            Console.WriteLine("****************");
                            z = false;
                        }
                        else
                        {
                            Console.WriteLine("Wrong username and password!");
                            Console.WriteLine("Do you want to try again? Y/N");
                            var opt = Console.ReadLine();
                            if (opt == "n")
                            {
                                z = false;
                            }
                        }

                        // END

                    }
                    break;
                    default:
                        Console.WriteLine("You selected invalid role, try again.");
                        break;
                }

            #endregion

            #region Logged

            if (currentAdmin != null)
            {
                while (true)
                {
                    Console.WriteLine("Would you like to : \n1.Add user \n2.Remove user \n3.exit");
                    var x = int.Parse(Console.ReadLine());

                    if (x == 1) // ADD USER
                    {
                        Console.WriteLine("Would you like to add: \n1.Admin \n2.Trainer \n3.Student");
                        // Boring code
                        break;
                    }
                    else if (x == 2) // REMOVE USER
                    {
                        Console.WriteLine("Would you like to remove: \n1.Admin \n2.Trainer \n3.Student");
                        // Boring code aswell
                        break;
                    }
                    else if (x == 3)
                    {
                        break;
                    }
                    else { Console.WriteLine("Invalid input!"); }
                    
                }

            }
            // END ADMIN

            else if (currentTrainer != null)
            {
                Console.WriteLine("Hey trainer");
            }
            // END TRAINER

            else if (currentStudent != null)
            {
                Console.WriteLine("Hey student");

            }
            // END STUDENT


            #endregion


            Console.ReadLine();
        }
    }
}

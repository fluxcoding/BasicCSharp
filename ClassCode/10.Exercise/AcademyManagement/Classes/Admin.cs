using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Classes
{
   public class Admin
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public Admin(string username, string password)
        {
            Username = username;
            Password = password;
        }



        public void RemoveAdmin(string name, List<Admin> Admins, Admin currentAdmin)
        {
            bool remove = false;

            foreach (var admin in Admins)
            {
                if (name == admin.Username && !(name == currentAdmin.Username))
                {
                    remove = true;
                    Admins.Remove(admin);
                    Console.WriteLine($"The user {admin.Username} has been successfully removed!");
                    break;
                }
            }
            if ((!remove) && (name != currentAdmin.Username))
            { Console.WriteLine("The user can not be found!"); }
            if ((!remove) && (name == currentAdmin.Username))
            { Console.WriteLine("You can't remove yourself! :)"); }

        }


        public void RemoveTrainer(string name, List<Trainer> Trainers)
        {
            bool remove = false;

            foreach (var trainer in Trainers)
            {
                if (name == trainer.Username)
                {
                    remove = true;
                    Trainers.Remove(trainer);
                    Console.WriteLine($"The user {trainer.Username} has been successfully removed!");
                    break;
                }
            }
            if (!remove)
            { Console.WriteLine("The user can not be found!"); }
           }


        public void RemoveStudent(string name, List<Student> Students)
        {
            bool remove = false;

            foreach (var student in Students)
            {
                if (name == student.Username)
                {
                    remove = true;
                    Students.Remove(student);
                    Console.WriteLine($"The user {student.Username} has been successfully removed!");
                    break;
                }
            }
            if (!remove)
            { Console.WriteLine("The user can not be found!"); }
        }






    }
}

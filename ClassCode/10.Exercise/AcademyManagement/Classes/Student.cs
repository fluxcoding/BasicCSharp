using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Classes
{
   public class Student
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public Student(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

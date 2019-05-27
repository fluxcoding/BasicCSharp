using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public RoleEnum Role{ get; set; }

        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Firstname : {FirstName} , Lastname : {LastName} , Salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

    }
}

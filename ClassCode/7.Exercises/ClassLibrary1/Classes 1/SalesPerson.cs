using ClassLibrary1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Classes_1
{
    public class SalesPerson : Employee
    {

        private double SuccessSaleRevenue { get; set; }

        public SalesPerson (string firstname, string lastname, int success)
        {
            FirstName = firstname;
            LastName = lastname;
            SuccessSaleRevenue = success;
            Salary = 500;
            Role = RoleEnum.Sales;
        }

        public void ExtendSuccessSaleRevenue(int successValue)
        {
            SuccessSaleRevenue += successValue;
        }



    }
}

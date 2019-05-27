using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime(2018, 1, 25);
            string stringDate = "01-25-2018";
            DateTime date3 = DateTime.Parse(stringDate);
            string stringdate2 = "01.25.2018";
            DateTime date4 = DateTime.Parse(stringdate2);


            DateTime date5 = DateTime.Today;
            DateTime date6 = DateTime.Now;

            //Console.WriteLine(date1);
            //Console.WriteLine(date2);
            //Console.WriteLine(date3);
            //Console.WriteLine(date4);

            //Console.WriteLine(date5);
            //Console.WriteLine(date6);

            //Console.WriteLine(date6.Month);
            //Console.WriteLine(date6.AddDays(5));
            //Console.WriteLine(date6.AddDays(-5));

            //Console.WriteLine(date5.ToString("dddd/MMMM/yyyyyyyy"));


            DateTime dejt1 = DateTime.Today;
            

            Console.ReadLine();
        }
    }
}

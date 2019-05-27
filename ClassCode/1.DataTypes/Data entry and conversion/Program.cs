using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_entry_and_conversion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter some number:");
            var result = Console.ReadLine();

            //var result = int.Parse(Console.ReadLine());

            //vaka so ova nad nas go skipnuvame bool dole cel step 

            //int parsedResult = int.Parse(result);
            //int convertedResult = Convert.ToInt32(result);
            
            int successfullResult;
            bool isSuccessfull = int.TryParse(result, out successfullResult);


            //Console.WriteLine("The value is " + result + " and the type is " + result.GetType());
            //Console.WriteLine("The value is " + parsedResult + " and the type is " + parsedResult.GetType());
            //Console.WriteLine("The value is " + convertedResult + " and the type is " + convertedResult.GetType());

           
            Console.WriteLine("The value is " + successfullResult + " and the type is " + successfullResult.GetType());
            Console.WriteLine("The value is " + isSuccessfull + " and the type is " + isSuccessfull.GetType());


            Console.ReadLine();

        }
    }
}

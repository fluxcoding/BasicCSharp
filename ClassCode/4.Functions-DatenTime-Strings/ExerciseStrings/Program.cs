using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseStrings
{
    class Program
    {
        static void Main(string[] args)
        {


            //char two = '"';


            //string first = $"Check your c:\\drive";
            ////string first = @"Check your c:\drive";
            ////string second = $"We will have {two}fair{two} Elections";
            //string second = @"We will have ""fair"" Elections";
            //string thirth = $"The \\n sign means: new line";
            ////string thirth = @"The \n sign means: new line";


            //string fourth = $@"Now we can use \ and {two}";
            //// use this

            //Console.WriteLine(first);
            //Console.WriteLine(second);
            //Console.WriteLine(thirth);
            //Console.WriteLine(fourth);
            //Console.ReadLine();

            string editableString = "Hello SEDC! We are learning C# Right now!";
            //Console.WriteLine(editableString.Length);
            //Console.WriteLine(editableString.ToLower());
            //Console.WriteLine(editableString.ToUpper());
            //Console.WriteLine(editableString.Substring(0,5));
            //// od 0 do 5 go pokazuva samo zborot
            //Console.WriteLine(editableString.Substring(5));
            //// prvite 5 gi brise drugoto go vrakja
            //Console.WriteLine(editableString.StartsWith("Hello"));
            //Console.WriteLine(editableString.IndexOf("SEDC"));
            Console.WriteLine(editableString.Split(' ')[0]);

            Console.WriteLine(editableString.ToCharArray()[2]);




            Console.ReadLine();


        }
    }
}

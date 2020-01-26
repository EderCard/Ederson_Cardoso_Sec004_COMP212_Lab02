using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ederson_Cardoso_Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // String to tested
            string stringTest = "This is to test whether the extension method count can return a right answer or not.";

            // Start StringBuilder
            StringBuilder sb = new StringBuilder(stringTest);

            // Call StringBuilder extention method CountWords
            int words = sb.CountWords(stringTest);

            Console.WriteLine("String test: ");
            Console.WriteLine(stringTest);
            // Print result           
            Console.WriteLine("The string tested has " + words + " words.");
        
        } // end Main
    } // end class
} // end namespace

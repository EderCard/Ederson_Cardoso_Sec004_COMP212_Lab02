using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ederson_Cardoso_Exercise02
{
    public static class StringBuilderExtension
    {
        /// <summary>
        /// This method returns the number of words in a string using StringBuilder extension method
        /// </summary>
        /// <param name="str"></param>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static int CountWords(this StringBuilder str, string inputString)
        {
            // Create a StringBuilder object
            StringBuilder builder = new StringBuilder(inputString);

            // Cast builder object as string
            string builderString = builder.ToString();

            // Split builderString in words separated by space and store it in an array
            string[] stringArray = builderString.Split(' ');

            // Return the number of words as array length
            return stringArray.Length;
        } // end CountWords method
    
    } // end class
} // end namespace

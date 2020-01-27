using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ederson_Cardoso_Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'};
            
            // Local variables
            int keyInt = 6;
            char keyChar = 'e';
            int position;

            #region Test IntArray
            // ****************************************************************
            // Test intArray 
            // ****************************************************************
            Console.Write("Array of Integers: ");
            DisplayArray(intArray);
            Console.WriteLine("Value to search: " + keyInt);
            
            // Find key position using genric method
            position = Search(intArray, keyInt);
            
            // Print result
            if (position == -1)
            {
                Console.WriteLine("Key not found.");
            }
            else
            {
                Console.WriteLine("Key found at position: " + position);
            }

            #endregion
            Console.WriteLine("-----------------------");

            #region Test charArray
            // ****************************************************************
            // Test charArray
            // ****************************************************************
            Console.Write("Array of chars: ");
            DisplayArray(charArray);
            Console.WriteLine("Value to search: " + keyChar);
            
            // Find key position using genric method
            position = Search(charArray, keyChar);
            
            // Print result
            if (position == -1)
            {
                Console.WriteLine("Key not found");
            }
            else
            {
                Console.WriteLine("Key found at position: " + position);
            }
            #endregion
        } // end main

        #region Search method
        /// <summary>
        /// This method return an element position in an array or -1 if element is not found
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataArray"></param>
        /// <param name="searchKey"></param>
        /// <returns></returns>
        public static int Search<T>(T[] dataArray, T searchKey) where T : IComparable<T>
        {
            int result = -1;
            for (int i = 0; i < dataArray.Length; i++)
                if (dataArray[i].CompareTo(searchKey) == 0)
                {
                    result = i;
                    break;
                }
            return result;
        } // end Search method
        #endregion

        #region DisplayArray method
        /// <summary>
        /// This method print an array using generic type argument
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputArray"></param>
        private static void DisplayArray<T>(T[] inputArray)
        {
            try
            {
                foreach (T element in inputArray)
                {
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        } // end DisplayArray method
        #endregion
    } // end class
} // end namespace

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ederson_Cardoso_Sec004_LinkedListLibrary;

namespace Ederson_Cardoso_Sec004_LinkedListLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region integerList
            // Create a list of integers           
            var integerList = new List<int>();
            integerList.InsertAtBack(42);
            integerList.InsertAtBack(51);
            integerList.InsertAtBack(15);
            integerList.InsertAtBack(33);
            integerList.InsertAtBack(24);
            // Print a list
            integerList.Display();
            
            // Get last node value
            Console.WriteLine("Last node of integer LinkedList is " + integerList.GetLastNode());
            Console.WriteLine("--------------------------------------------------");
            #endregion

            #region doubleList
            // Create a list of doubles
            var doubleList = new List<double>();
            doubleList.InsertAtBack(42.2);
            doubleList.InsertAtBack(51.1);
            doubleList.InsertAtBack(15.5);
            doubleList.InsertAtBack(33.3);
            doubleList.InsertAtBack(24.4);
            // Print a list
            integerList.Display();

            // Get last node value
            Console.WriteLine("Last node of double LinkedList is " + doubleList.GetLastNode());
            Console.WriteLine("--------------------------------------------------");
            #endregion

            #region MinumumValue
            // Get minumum node value
            Console.WriteLine("The minimum value of integer LinkedList is " + integerList.Minimum());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("The minimum value of double LinkedList is " + doubleList.Minimum());
            Console.WriteLine("--------------------------------------------------");
            #endregion
        } // end Main
    } // end Class
} // end namespace

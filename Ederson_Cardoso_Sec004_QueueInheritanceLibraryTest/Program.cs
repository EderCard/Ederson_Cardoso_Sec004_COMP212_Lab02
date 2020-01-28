using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ederson_Cardoso_Sec004_LinkedListLibrary;
using Ederson_Cardoso_Sec004_QueueInheritanceLibrary;

namespace Ederson_Cardoso_Sec004_QueueInheritanceLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region integerQueue
            // Create a queue of integers           
            var integerQueue = new QueueInheritance<int>();
            
            // Populate values
            integerQueue.Enqueue(42);
            integerQueue.Enqueue(51);
            integerQueue.Enqueue(15);
            integerQueue.Enqueue(33);
            integerQueue.Enqueue(24);
            
            // Print a queue
            integerQueue.Display();
            
            // Get last node value
            Console.WriteLine("Last element in integer queue is " + integerQueue.GetLast());
            Console.WriteLine("--------------------------------------------------");
            #endregion

            #region doubleQueue
            // Create a queue of doubles
            var doubleQueue = new QueueInheritance<double>();

            // Populate values
            doubleQueue.Enqueue(42.2);
            doubleQueue.Enqueue(51.1);
            doubleQueue.Enqueue(15.5);
            doubleQueue.Enqueue(33.3);
            doubleQueue.Enqueue(24.4);
            
            // Print a queue
            doubleQueue.Display();

            // Get last node value
            Console.WriteLine("Last element of double queue is " + doubleQueue.GetLast());
            Console.WriteLine("--------------------------------------------------");
            #endregion

            #region MinumumValue
            // Get minumum node value
            Console.WriteLine("The minimum value of integer queue is " + integerQueue.Minimum());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("The minimum value of double queue is " + doubleQueue.Minimum());
            Console.WriteLine("--------------------------------------------------");
            #endregion
        }// end Main
    } // end class
} // end namespace

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ederson_Cardoso_Sec004_LinkedListLibrary;

namespace Ederson_Cardoso_Sec004_QueueInheritanceLibrary
{
    // class QueueInheritance inherits List's capabilities
    public class QueueInheritance<T> : List<T> where T : IComparable<T>
    //public class QueueInheritance<T> : List<T> 
    {
        #region LabCode
        // pass name "queue" to List constructor
        public QueueInheritance() : base("queue") { }

        // place dataValue at end of queue by inserting 
        // dataValue at end of linked list
        public void Enqueue(T dataValue)
        {
            InsertAtBack(dataValue);
        }

        // remove item from front of queue by removing
        // item at front of linked list
        public T Dequeue()
        {
            return RemoveFromFront();
        }
        #endregion

        #region Exercise03
        /// <summary>
        /// This method returns the last node of queue using the LinkedList GetLastNode() method
        /// </summary>
        /// <returns></returns>
        public T GetLast()
        {
            return GetLastNode();
        }
        #endregion
    } // end class
} // end namespace

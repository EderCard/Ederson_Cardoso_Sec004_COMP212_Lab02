using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ederson_Cardoso_Sec004_LinkedListLibrary
{
    public class ListNode<T> where T : IComparable<T> // add IComparable to use CompareTo()
    {
        // automatic read-only property Data
        public T Data { get; private set; }

        // automatic property Next
        // public ListNode Next { get; set; }
        public ListNode<T> Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(T dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
}

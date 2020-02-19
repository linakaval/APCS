using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListTester
{
    class ListNode
    {
        private Object myValue;
        private ListNode myNext;

        /// <summary>
        /// Creates a ListNode
        /// </summary>
        /// <param name="value"> Value of the list item </param>
        /// <param name="next"> The next item in the list </param>
        public ListNode(Object value, ListNode next)
        {
            myValue = value;
            myNext = next;
        }

        /// <summary>
        /// Sets the value of the list item
        /// </summary>
        /// <param name="value"> New value of the list item  </param>
        public void setValue(Object value)
        {
            myValue = value;
        }

        /// <summary>
        /// Gets the value of the list item
        /// </summary>
        /// <returns> The value of the list item </returns>
        public Object getValue()
        {
            return myValue;
        }

        /// <summary>
        /// Sets a new item as the next item in the list
        /// </summary>
        /// <param name="next"> Next item in the list </param>
        public void setNext(ListNode next)
        {
            myNext = next;
        }

        /// <summary>
        /// Returns the next item in the list
        /// </summary>
        /// <returns> Next item in the list </returns>
        public ListNode getNext()
        {
            return myNext;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackADT
{
    class StackADT
    {
        //CHANGE EXCEPTIONS

        private ListNode top, tail, newNode;
        private int myCount;

        /// <summary>
        /// Constructor for ListADT
        /// </summary>
        public StackADT()
        {

        }

        /// <summary>
        /// Pushes an object onto the stack
        /// </summary>
        /// <param name="data"> Input to the stack </param>
        public void push(Object data)
        {
            if (isEmpty())
            {
                top = new ListNode(data, null);
            }
            else
            {
                top = new ListNode(data, top);
            }
            myCount++;
        }

        /// <summary>
        /// Pops the item off the stack
        /// </summary>
        /// <returns> The top item </returns>
        public object pop()
        {
            object toBeReturned;
            if (top == null)
            {
                throw new InvalidOperationException();
            }

            toBeReturned = top.getValue();
            top = top.getNext();

            myCount--;
            return toBeReturned;
        }

        /// <summary>
        /// Peek at the top item in the stack
        /// </summary>
        /// <returns> The top item in the stack </returns>
        public object peek()
        {
            if (top == null)
            {
                throw new ArgumentException();
            }

            return top.getValue();
        }

        /// <summary>
        /// Checks to see if the stack exists
        /// </summary>
        /// <returns> Whether the stack exists or not (T or F) </returns>
        public bool isEmpty()
        {
            return (top == null);
        }

        /// <summary>
        /// Checks to see if the stack is full
        /// </summary>
        /// <returns> Whether the stack is full or not (T or F) </returns>
        public bool isFull()
        {
            return false;
        }

        /// <summary>
        /// Gets the number of items in the stack
        /// </summary>
        /// <returns> The number of items in the stack </returns>
        public int getCount()
        {
            return myCount;
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns> The fixed string </returns>
        public override string ToString()
        {
            ListNode temp = top;
            int index = 0;
            string result = "";

            while (temp != null)
            {
                result += index + ") " + temp.getValue() + Environment.NewLine;
                temp = temp.getNext();
                index++;
            }
            return result;
        }
    }
}

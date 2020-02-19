using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListTester
{
    class ListADT
    {
        private ListNode head, tail, newNode;
        private int myCount;

        /// <summary>
        /// Constructor for ListADT
        /// </summary>
        public ListADT()
        {
                                                                                                                                                               
        }

        /// <summary>
        /// Adds to the list
        /// </summary>
        /// <param name="data"> Input to the list </param>
        public void add(Object data)
        {
            newNode = new ListNode(data, null);
            if (isEmpty())
            {
                head = newNode;
            }
            else
            {
                tail.setNext(newNode);            
            }
            tail = newNode;
            myCount++;
        }


        /// <summary>
        /// Adds to the list at a specific index
        /// </summary>
        /// <param name="data"> Input to the list </param>
        /// <param name="index"> The index you want to add at </param>
        public void add(Object data, int index)
        {
            if (index < 0)
            {
                throw new ArgumentException();

            }
            else if (index >= myCount)
            {
                add(data);
            }
            else
            {
                if (index == 0)
                {
                    head = new ListNode(data, head);
                }
                else
                {
                    ListNode temp = head;
                    for (int i = 0; i < index - 1; i++)
                    {
                        temp = temp.getNext();
                    }
                    temp.setNext(new ListNode(data, temp.getNext()));
                }
                myCount++;
            }
        }


        /// <summary>
        /// Removes the item from the list at a specific index
        /// </summary>
        /// <param name="index"> The index you want to remove at </param>
        /// <returns></returns>
        public object remove(int index)
        {
            object toBeReturned;
            if (head == null)
            {
                throw new ArgumentException();
            }
            else if (index == 0)
            {
                toBeReturned = head.getValue();
                head = head.getNext();
            }
            else if (index > myCount || index < 0)
            {
                throw new ArgumentException();
            }
            else if (index == myCount)
            {
                ListNode temp = head;
                while (temp.getNext().getNext() != null)
                {
                    temp = temp.getNext();
                }
                toBeReturned = temp.getNext().getValue();
                temp.setNext(null);
                tail = temp;
            }
            //for every okay case
            else
            {
                ListNode temp = head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.getNext();
                }
                toBeReturned = temp.getNext().getValue();
                temp.setNext(temp.getNext().getNext());
                tail = temp;
            }
            myCount--;
            return toBeReturned;
        }

        /// <summary>
        /// Gets the number of items in the list
        /// </summary>
        /// <returns> The number of items in the list </returns>
        public int getCount()
        {
            return myCount;
        }

        /// <summary>
        /// Return the value at a specified index
        /// </summary>
        /// <param name="index"> The index you want to get data from </param>
        /// <returns></returns>
        public object getData(int index)
        {
            if (index > myCount || index < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                ListNode temp = head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.getNext();
                }
                return temp.getValue();
            }
        }

        /// <summary>
        /// Set a value at the specified index
        /// </summary>
        /// <param name="index"> The index you want set data at </param>
        /// <param name="value"> The value you want to set</param>
        /// <returns></returns>
        public object setData(int index, object value)
        {
            object original;
            if (index > myCount || index < 0)
            {
                throw new ArgumentException();
            }
            else
            { 
                ListNode temp = head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.getNext();
                }
                original = temp.getValue();
                temp.setValue(value);
            }
            return original;
        }

        /// <summary>
        /// Clears the list
        /// </summary>
        public void clear()
        {
            head = null;
            tail = null;
            myCount = 0;
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns> The fixed string </returns>
        public override string ToString()
        {
            ListNode temp = head;
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

        /// <summary>
        /// Checks to see if the list exists
        /// </summary>
        /// <returns> Whether the list exists or not (T or F) </returns>
        public bool isEmpty()
        {
            return (head == null);
        }
    }
}

// Source URL: http://www.algorithmist.com/index.php/Bubble_sort

//still NEED comments

using System;

namespace SortingStuff
{
    public class BubbleSorter : Sorter  // Java version: extends Sorter
    {
        public BubbleSorter()
            : base("Bubble")
        {
        }

        /* Java version:
         * public BubbleSorter()
         * {
         *     super("Bubble");
         * }
         */

        //TODO: Implement a Bubble Sort.

        /// <summary>
        /// Sorts the array using a bubble sort
        /// </summary>
        public override void sort()
        {
            // boolean variable to keep track of whether an item has been been swapped or not
            bool swapped = true;

            // while the loop is true
            while (swapped == true)
            {
                //change swapped to false
                swapped = false;

                // for loop to go through each element
                for (int y = 0; y < data.Length - 1; y++)
                {
                    // if the item in the array is greater than the next item in the array
                    if (data[y] > data[y + 1])
                    {
                        // change swapped to true beacause the next step is swapping the items
                        swapped = true;
                        // swaps the items
                        swap(y, y + 1);
                    }
                }
            }
        }
    }
}

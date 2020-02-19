// Source URL: http://cforbeginners.com/CSharp/SelectionSort.html

using System;

namespace SortingStuff
{
    public class SelectionSorter : Sorter   // Java version: extends Sorter
    {
        public SelectionSorter()
            : base("Selection")
        {
        }

        /* Java version:
         * public SelectionSorter()
         * {
         *     super("Selection");
         * }
         */

        //TODO: Implement a Selection Sort.
        public override void sort()
        { 
            //pos_min is short for position of min. pointers to the minimum value in the array
            int pos_min;

            //loops through the array
            for (int i = 0; i < data.Length - 1; i++)
            {
                pos_min = i; //set pos_min to the current index of array

                //loops through everything below the pos_min value
                for (int j = i + 1; j < data.Length; j++)
                {
                    //if one of the data values located below pos_min is smaller than pos_min
                    if (data[j] < data[pos_min])
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                    }
                }
                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i) swap(i, pos_min);
            }
        }

    }
}

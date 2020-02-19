// Source URL: http://www.algorithmist.com/index.php/Insertion_sort

using System;

namespace SortingStuff
{
    public class InsertionSorter : Sorter   // Java version: extends Sorter
    {
        public InsertionSorter()
            : base("Insertion")
        {
        }

        /* Java version:
         * public InsertionSorter()
         * {
         *     super("Insertion");
         * }
         */

        //TODO: Implement an Insertion Sort.
        public override void sort()
        {
            //int variables to point to a pos_min tracker that keeps track minimum value, j is an index to be used when shifting all the indexes
            int pos_min, j;

            // iterates through each data item
            for (int x = 1; x < data.Length; x++)
            {
                // sets minimum value to the current indexed data value
                pos_min = data[x];

                // j is one less than the index to make comparing easy in the next while loop
                j = x - 1;

                // while the index before 
                while (j >= 0 && data[j] > pos_min)
                {
                    data[j + 1] = data[j];
                    j = j - 1;
                }

                data[j + 1] = pos_min;
            }
        }
    }
}


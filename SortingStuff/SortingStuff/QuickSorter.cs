//Source URL: http://snipd.net/quicksort-in-c

//still NEEDS comments

using System;

namespace SortingStuff
{
    class QuickSorter : Sorter
    {
        public QuickSorter() 
            : base("Quick")
        {
        }

        /* Java version:
                 * public QuickSorter()
                 * {
                 *     super("Quick");
                 * }
                 */

        //TODO: Implement a Quick Sort.
        public override void sort()
        {
            sort(0, data.Length - 1);
        }

        private void sort(int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = data[(left + right) / 2];

            while (i <= j)
            {
                while (data[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (data[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    swap(i, j);

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                sort(left, j);
            }

            if (i < right)
            {
                sort(i, right);
            }
        }
    }
}

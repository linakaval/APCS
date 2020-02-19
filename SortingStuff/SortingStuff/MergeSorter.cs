//Source URL: https://begeeben.wordpress.com/2012/08/21/merge-sort-in-c/

//also NEED comments

using System;

namespace SortingStuff
{
    class MergeSorter : Sorter
    {
        public MergeSorter() 
            : base("Merge")
        {

        }

        /* Java version:
                 * public MergeSorter()
                 * {
                 *     super("Merge");
                 * }
                 */

        //TODO: Implement a Merge Sort.
        public override void sort()
        {
            sort(0, data.Length - 1);
        }

        private void sort(int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                sort(left, middle);
                sort(middle + 1, right);

                //Merge
                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(data, left, leftArray, 0, middle - left + 1);
                Array.Copy(data, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        data[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        data[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        data[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        data[k] = rightArray[j];
                        j++;
                    }
                }
            }
        }
    }
}
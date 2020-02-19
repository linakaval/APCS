//Source URL: http://www.dotnetlovers.com/article/131/implementation-and-analysis-of-heap-sort

using System;

namespace SortingStuff
{
    class HeapSorter : Sorter
    {
        private Heap myHeap;

        public HeapSorter() 
            : base("Heap")
        {

        }

        /* Java version:
                 * public HeapSorter()
                 * {
                 *     super("Heap");
                 * }
                 */

        //TODO: Implement a Heap Sort.
        public override void sort()
        {
            myHeap = new Heap(data, data.Length);
            myHeap.BuildHeap();
            for (int i = myHeap.heapSize; i > 0; i--)
            {
                myHeap.Swap(i, 0);
                myHeap.subtractHeapSize();
                myHeap.MaxHeapify(0);
            }
        }
    }
}

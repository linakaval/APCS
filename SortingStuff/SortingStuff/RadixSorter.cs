﻿//Source URL: https://stackoverflow.com/questions/1327614/any-ready-made-implementation-of-radix-sort-for-c

using System;

namespace SortingStuff
{
    class RadixSorter : Sorter
    {
        public RadixSorter() 
            : base("Radix")
        {
        }

        /* Java version:
                 * public RadixSorter()
                 * {
                 *     super("Radix");
                 * }
                 */

        //TODO: Implement a Radix Sort.
        public override void sort()
        {
            // our helper array 
            int[] t = new int[data.Length];

            // number of bits our group will be long 
            int r = 4; // try to set this also to 2, 8 or 16 to see if it is 
                       // quicker or not 

            // number of bits of a C# int 
            int b = 32;

            // counting and prefix arrays
            // (note dimensions 2^r which is the number of all possible values of a 
            // r-bit number) 
            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];

            // number of groups 
            int groups = (int)Math.Ceiling((double)b / (double)r);

            // the mask to identify groups 
            int mask = (1 << r) - 1;

            // the algorithm: 
            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                // reset count array 
                for (int j = 0; j < count.Length; j++)
                    count[j] = 0;

                // counting elements of the c-th group 
                for (int i = 0; i < data.Length; i++)
                    count[(data[i] >> shift) & mask]++;

                // calculating prefixes 
                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                    pref[i] = pref[i - 1] + count[i - 1];

                // from data[] to t[] elements ordered by c-th group 
                for (int i = 0; i < data.Length; i++)
                    t[pref[(data[i] >> shift) & mask]++] = data[i];

                // data[]=t[] and start again until the last group 
                t.CopyTo(data, 0);
            }
            // a is sorted 
        }
    }
}
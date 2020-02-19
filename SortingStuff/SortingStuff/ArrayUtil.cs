using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingStuff
{
    class ArrayUtil
    {
        public static int[] randomIntArray(int length, int n)
        {
            int[] a = new int[length];
            Random generator = new Random();

            for (int i = 0; i < a.Length; i++)
                a[i] = generator.Next(n + 1);

            return a;
        }

        /** 
           Prints all elements in an array.
           @param a the array to print
        */
       public static void print(int[] a)
       {  
          for (int i = 0; i < a.Length; i++)
             System.Console.Write(a[i] + " ");
          System.Console.WriteLine();
       }
    }
}

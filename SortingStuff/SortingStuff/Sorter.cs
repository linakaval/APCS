using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingStuff
{
    public abstract class Sorter
    {
        protected int[] data;
        private string sortName;

        public Sorter(string name)
        {
            sortName = name;
        }

        public string getName() { return sortName; }

        public void addData(int[] a)
        {
            data = a;
        }

        public int[] getData()
        {
            return data;
        }

        public void swap(int i, int j)
        {
            int temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }


        public abstract void sort();
    }
}

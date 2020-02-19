using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SortingStuff
{
    public partial class Form1 : Form
    {
        private System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        private Results resultDlg;

        public Form1()
        {
            InitializeComponent();

            resultDlg = new Results();
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            resultDlg.clearSorts();

            // grab the screen data.
            int shortQty, longQty, maxValue;
            try
            {
                shortQty = Convert.ToInt32(txtShortQty.Text);
                longQty = Convert.ToInt32(txtLongQty.Text);
                maxValue = Convert.ToInt32(txtMaxValue.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Invalid numeric input.");
                return;
            }

            // create a short list and a long list of numbers (int).
            int[] shortList = ArrayUtil.randomIntArray(shortQty, maxValue);
            int[] longList = ArrayUtil.randomIntArray(longQty, maxValue);

            // create a list of sort objects
            List<Sorter> sorts = new List<Sorter>();
            sorts.Add(new BubbleSorter());
            sorts.Add(new SelectionSorter());
            sorts.Add(new InsertionSorter());
            sorts.Add(new MergeSorter());
            sorts.Add(new QuickSorter());
            sorts.Add(new HeapSorter());
            sorts.Add(new RadixSorter());

            String results = "               - - - Short List - - -    - - - Long List - - -\n" +
                             "Sort Name      Unordered      Ordered    Unordered     Ordered\n" +
                             "============   =========    =========    =========   =========\n";

            // loop through the sorts.
            foreach (Sorter s in sorts)
            {
                // grab the next sort and output its name.
                results += String.Format("{0,12}", s.getName());
                displayResults(results);

                // give the sort a copy of the short list and sort it.
                s.addData((int[])shortList.Clone());
                results += String.Format("{0,12}", timeSort(s));
                displayResults(results);

                // send the sort to the results dialog box.
                resultDlg.addSort(s);

                // now see how it does on an already sorted list.
                results += String.Format("{0,13}", timeSort(s));
                displayResults(results);

                // give the sort a copy of the long list and sort it.
                s.addData((int[])longList.Clone());
                results += String.Format("{0,13}", timeSort(s));
                displayResults(results);

                // sort it again.
                results += String.Format("{0,12}", timeSort(s));

                results += "\n";
            }

            lblResults.Text = (results + "\nFinished!");

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            resultDlg.ShowDialog();
        }

        // perform and time the sort operation.
        private long timeSort(Sorter s)
        {
            //long start = System.currentTimeMillis();
            sw.Reset();
            sw.Start();
            s.sort();
            sw.Stop();
            return sw.ElapsedTicks;//System.currentTimeMillis()-start;
        }

        // display the current results on the form.
        private void displayResults(String results)
        {
            lblResults.Text = (results + "  Working...");
            this.Refresh();
        }

    }
}

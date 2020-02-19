using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SortingStuff
{
    public partial class Results : Form
    {
        private List<int[]> sorts;

        public Results()
        {
            InitializeComponent();

            sorts = new List<int[]>();
        }

        public void addSort(Sorter s)
        {
            sorts.Add((int[])s.getData().Clone());

            lstSorts.Items.Add(s.getName());
        }

        public void clearSorts()
        {
            sorts = new List<int[]>();
            lstSorts.Items.Clear();
        }

        private void lstSorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstSorts.SelectedIndex;
            int[] a = sorts[index];
            lblCount.Text = ("" + a.Length);
            string sb = "";
            for (int lcv = 0; lcv < a.Length; lcv++)
            {
                sb += a[lcv] + "\r\n";
            }
            txtData.Text = sb;

        }


    }
}

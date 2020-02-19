using System;
using System.Windows.Forms;

namespace ListTester
{
    public partial class Form1 : Form
    {
        ListADT list = new ListADT();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //TODO: Insert new data at user-specified index.  If the index is -1, then add item to the end.
            int index = Convert.ToInt32(txtIndex.Text);
            try
            {
                if (index == -1)
                {
                    list.add(txtData.Text);
                }
                else
                {
                    list.add(txtData.Text, index);
                }
                txtData.Text = "";
                refreshScreen();
            }
            catch (FormatException)
            {
                MessageBox.Show("Index is not valid. Try again.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Index out of range! Try again.");
            }
        }

        private void cmdSet_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text);
            string value = Convert.ToString(txtData.Text);
            try
            {
                txtData.Text = Convert.ToString(list.setData(index, value));
                refreshScreen();
            }
            catch (FormatException)
            {
                MessageBox.Show("Index is not valid. Try again.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Index out of range! Try again.");
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            //TODO: Delete item from the list at specified index.
            try
            {
                string itemReturned;
                itemReturned = Convert.ToString(list.remove(Convert.ToInt32(txtIndex.Text)));
                txtData.Text = itemReturned;
                refreshScreen();
            }
            catch (FormatException)
            {
                MessageBox.Show("Index is not valid. Try again.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Index out of range! Try again.");
            }

        }

        private void cmdGet_Click(object sender, EventArgs e)
        {
            //TODO: Get the item from the list at the specified index.
            try
            {
                int index = Convert.ToInt32(txtIndex.Text);
                string itemReturned;
                itemReturned = Convert.ToString(list.getData(index));
                txtData.Text = itemReturned;
                refreshScreen();
            }
            catch (FormatException)
            {
                MessageBox.Show("Index is not valid. Try again.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Index out of range! Try again.");
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            list.clear();
            refreshScreen();
            txtData.Text = "";
            txtIndex.Text = "0";
        }

        private void refreshScreen()
        {
            //TODO: Refresh the list, count and empty labels.
            lblCount.Text = list.getCount().ToString();
            txtList.Text = list.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshScreen();
        }
    }
}

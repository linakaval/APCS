using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diver
{
    public partial class Form1 : Form
    {
        Cave cave;

        public Form1()
        {
            InitializeComponent();
            cave = new Cave(10, 10, 40);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            cave.paint(e.Graphics);
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            cave.clearEscapeRoutes();
            Refresh();
            int depth = Convert.ToInt32(txtBoxDepth.Text);
            cave.findEscapeRoute(depth, 0, 0);
            Refresh();
            if (cave.findEscapeRoute(depth, 0, 0))
            {
                Refresh();
                lblOutput.Text = "Yay, you got out!";
            }
            else
            {
                lblOutput.Text = "You're dead.";
            }
        }

        private void btnNewCave_Click(object sender, EventArgs e)
        {
            int seed;
            if (string.IsNullOrWhiteSpace(txtBoxSeed.Text))
            {
                cave = new Cave(10, 10, 40);
                Refresh();
            }
            else
            {
                seed = Convert.ToInt32(txtBoxSeed.Text);
                cave = new Cave(seed, 10, 10, 40);
                Refresh();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            cave.clearEscapeRoutes();
            Refresh();
        }
    }
}

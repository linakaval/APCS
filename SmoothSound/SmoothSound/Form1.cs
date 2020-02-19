using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoothSound
{
    public partial class Form1 : Form
    {
        private string fileName = "soundData.txt";
        private SoundSmoother ss;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ss = new SoundSmoother(fileName, 300, 2, 1, pictureBox1.ClientRectangle.Bottom - 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ss.smoothIt();
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            ss.paint(e.Graphics);
        }
    }
}

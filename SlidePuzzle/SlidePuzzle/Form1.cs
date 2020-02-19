using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SlidePuzzle
{
    public partial class Form1 : Form
    {
        SlidePuzzleGame game;
        
        /// <summary>
        /// Used to make a new SlidePuzzleGame
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            game = new SlidePuzzleGame(3, 100, imageList1);
        }

        /// <summary>
        /// Paints the pictureBoc
        /// </summary>
        /// <param name="sender">the object</param>
        /// <param name="e">the Paint event</param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            game.paint(e.Graphics);
        }

        /// <summary>
        /// Captures a mouse click
        /// </summary>
        /// <param name="sender"> the object</param>
        /// <param name="e"> the mouse event</param>
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            game.move(e.Location);
            bool win = game.move(e.Location);
            Refresh();
            if (win)
            {
                string message = String.Format("You won! \nTime: {0} seconds\nMoves made: {1}", game.getTime(), game.getNumberOfMoves());
                DialogResult result = MessageBox.Show(message, "", MessageBoxButtons.OK);
            }
        }
    }
}

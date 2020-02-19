using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        private List<APShape> shapes = new List<APShape>();
        private enum ShapeType
        {
            LINE, BOX, OVAL
        }
        private ShapeType currentShape = ShapeType.LINE;
        private bool trails = false;
        private bool drag = false;
        private bool dance = false;
        private Bitmap background;

        public Form1()
        {
            InitializeComponent();

            int cols = canvas.Width;
            int rows = canvas.Height;
            Color shade = Color.White;
            System.Random rnd = new System.Random();
            background = new Bitmap(cols, rows);

            for (int c = 0; c < cols; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    //shade = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                    background.SetPixel(c, r, shade);
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'l':
                    currentShape = ShapeType.LINE;
                    break;
                case 'o':
                    currentShape = ShapeType.OVAL;
                    break;
                case 'r':
                    currentShape = ShapeType.BOX;
                    break;
                case 't':
                    trails = !trails;
                    break;
                case 'd':
                    dance = !dance;
                    break;
                case 'c':
                    shapes.Clear();
                    Refresh();
                    break;
                default:
                    break;
            }

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;

            switch (currentShape)
            {
                case ShapeType.LINE:
                    shapes.Add(new APLine(e.X, e.Y, e.X, e.Y, Color.Green));
                    break;
                case ShapeType.BOX:
                    shapes.Add(new APBox(e.X, e.Y, e.X, e.Y, Color.Red));
                    break;
                case ShapeType.OVAL:
                    shapes.Add(new APOval(e.X, e.Y, e.X, e.Y, Color.Blue));
                    break;
                default:
                    break;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            shapes.Last().setY2(e.Y);
            shapes.Last().setX2(e.X);
            Refresh();

            drag = false;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (dance)
            {
                foreach (var item in shapes)
                {
                    item.setX2(e.X);
                    item.setY2(e.Y);
                    Refresh();
                }
            }
            if (trails)
            {
                switch (currentShape)
                {
                    case ShapeType.LINE:
                        shapes.Add(new APLine(shapes.Last().getX1(), shapes.Last().getY1(), e.X, e.Y, Color.Green));
                        break;
                    case ShapeType.BOX:
                        shapes.Add(new APBox(shapes.Last().getX1(), shapes.Last().getY1(), e.X, e.Y, Color.Red));
                        break;
                    case ShapeType.OVAL:
                        shapes.Add(new APOval(shapes.Last().getX1(), shapes.Last().getY1(), e.X, e.Y, Color.Blue));
                        break;
                    default:
                        break;
                }
                Refresh();
            }

            if (drag)
            {
                shapes.Last().setY2(e.Y);
                shapes.Last().setX2(e.X);
                Refresh();
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Draw background sparkles
            g.DrawImage(background, 0, 0);

            foreach (var item in shapes)
            {
                item.draw(e.Graphics);
            }

        }
    }
}

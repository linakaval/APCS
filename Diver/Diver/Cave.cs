using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver
{
    class Cave
    {
        private Random gen;
        private CaveCell[,] myCave;
        private Color[] myColors;
        private int myCellSize, numRows, numCols;

        /// <summary>
        /// Makes a cave
        /// </summary>
        /// <param name="rows"> Rows of the cave</param>
        /// <param name="cols">Columns of the cave</param>
        /// <param name="cellSize">Size of the cave cells</param>
        public Cave(int rows, int cols, int cellSize)
        {
            gen = new Random();
            numRows = rows;
            numCols = cols;
            myCave = new CaveCell[numCols, numRows];
            myCellSize = cellSize;
            myColors = new Color[10];
            setColors();
            makeTiles();           
        }

        /// <summary>
        /// Makes a cave using a seed value
        /// </summary>
        /// <param name="seedValue">Value to get the same cave every time</param>
        /// <param name="rows"> Rows of the cave</param>
        /// <param name="cols">Columns of the cave</param>
        /// <param name="cellSize">Size of the cave cells</param>
        public Cave(int seedValue, int rows, int cols, int cellSize)
        {
            numRows = rows;
            numCols = cols;
            myCave = new CaveCell[numCols, numRows];
            myCellSize = cellSize;
            gen = new Random(seedValue);
            myColors = new Color[10];
            setColors();
            makeTiles();
        }

        /// <summary>
        /// Make the cave
        /// </summary>
        private void makeTiles()
        {
            for (int c = 0; c < myCave.GetLength(0); c++)
            {
                for (int r = 0; r < myCave.GetLength(1); r++)
                {
                    int temp = gen.Next(0, 10);
                    myCave[c, r] = new CaveCell(temp + 1, new Location(c,r), myCellSize, myColors[temp], Color.Red);
                }
            }
        }

        /// <summary>
        /// Paints the cave
        /// </summary>
        /// <param name="g"> Graphics object </param>
        public void paint(Graphics g)
        {
            foreach (var item in myCave)
            {
                item.paint(g);
            }
        }

        /// <summary>
        /// Clears the escape route
        /// </summary>
        public void clearEscapeRoutes()
        {
            foreach (var item in myCave)
            {
                item.setColor(false);
            }
        }

        /// <summary>
        /// Sets the color range of the cave
        /// </summary>
        private void setColors()
        {
            for (int i = 0; i < 10; i++)
            {
                myColors[i] = Color.FromArgb(0, 0, 255 - (i * 25));
            }
        }

        /// <summary>
        /// Finds the escape route
        /// </summary>
        /// <param name="diverDepth"> Depth the diver can swim in</param>
        /// <param name="r"> rows </param>
        /// <param name="c"> columns </param>
        /// <returns> Returns a boolean value for the recursive method </returns>
        public bool findEscapeRoute(int diverDepth, int r, int c)
        {
            if (r > numRows - 1 || c > numCols - 1)
            {
                return false;
            }
            else if (diverDepth < myCave[c,r].getDepth())
            {
                return false;
            }
            else if (r == numRows-1 && c == numCols-1)
            {
                myCave[c, r].setColor(true);
                return true;
            }
            else if (!findEscapeRoute(diverDepth, r, c+1))
            {
                if (!findEscapeRoute(diverDepth, r + 1, c))
                {
                    return false;
                }               
            }
            myCave[c, r].setColor(true);
            return true;
        }
    }
}

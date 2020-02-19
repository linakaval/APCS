using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidePuzzle
{
    class SlidePuzzleGame
    {
        private Tile[,] myGrid;
        private Stopwatch time = new Stopwatch();
        private int numberOfMoves;
        private ImageList myImages;
        private int myTileSize;
        private Location blank;


        /// <summary>
        /// Constructs the Slide Puzzle Game 
        /// </summary>
        /// <param name="rowsColumns"> the number of rows/columns you want in the game </param>
        /// <param name="tileSize"> the size of the tiles </param>
        /// <param name="images"> the images for the tiles </param>
        public SlidePuzzleGame(int rowsColumns, int tileSize, ImageList images)
        {
            myGrid = new Tile[rowsColumns, rowsColumns];
            myImages = images;
            myTileSize = tileSize;
            blank = new Location(rowsColumns - 1, rowsColumns - 1);
            makeTiles();
            randomize(10, rowsColumns);
            time.Start();
        }

        /// <summary>
        /// Creates Tiles and adds them to the array
        /// </summary>
        private void makeTiles()
        {
            int value = 0;
            for (int r = 0; r < myGrid.GetLength(0); r++)
            {
                for (int c = 0; c < myGrid.GetLength(1); c++)
                {
                    myGrid[r, c] = new Tile(value, myTileSize, new Location(r, c), myImages.Images[value]);
                    value++;
                }
            }
        }

        /// <summary>
        ///Using a point clicked, it swaps the Tile with the blank Tile and checks to see if the game was won
        /// </summary>
        /// <param name="mouseClick"> The click point obtained from the Form</param>
        /// <returns></returns>
        public bool move(Point mouseClick)
        {
            //changes the mouseclick into a location
            Location clicked = new Location(mouseClick.Y / 100, mouseClick.X / 100);

            //checks the location of the mouseclick with the blank THEN changes the tiles
            if (isValidClick(clicked))
            {
                swap(clicked, blank);
                blank = clicked;
            }
            return checkForWinner();
        }

        /// <summary>
        /// Checks to make sure the Tile and the blank Tile are next to each other and keeps track of the number of moves
        /// </summary>
        /// <param name="clicked">The location of the clicked point, obtained from the move method</param>
        /// <returns></returns>
        public bool isValidClick(Location clicked)
        {
            if ((Math.Abs(clicked.getRow() - blank.getRow()) + 
                Math.Abs(clicked.getColumn() - blank.getColumn()) == 1))
            {
                numberOfMoves++;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Paints the tiles in the tile array
        /// </summary>
        /// <param name="g">The graphics object</param>
        public void paint(Graphics g)
        {
            foreach (var item in myGrid)
            {
                item.paint(g);
            }
        }

        /// <summary>
        /// Gets the number of moves
        /// </summary>
        /// <returns>The number of moves made</returns>
        public int getNumberOfMoves()
        {
            return numberOfMoves;
        }

        /// <summary>
        /// Gets the time since the Form was created
        /// </summary>
        /// <returns>The time elapsed</returns>
        public int getTime()
        {
            TimeSpan ts = time.Elapsed;
            return ts.Seconds;
        }

        /// <summary>
        /// Checks each item in the array to see if it is in the correct position, then stops time
        /// </summary>
        /// <returns>Whether the game has been won or not (true or false)</returns>
        private bool checkForWinner()
        {
            int value = 0;
            for (int r = 0; r < myGrid.GetLength(0); r++)
            {
                for (int c = 0; c < myGrid.GetLength(1); c++)
                {
                    if (myGrid[r,c].getValue() != value)
                    {
                        return false;
                    }
                    value++;
                }
            }
            time.Stop();
            return true;
        }

        /// <summary>
        /// Randomizes the tiles by swapping
        /// </summary>
        /// <param name="randomInt">The number of times to randomize</param>
        /// <param name="gridSize">The size of the grid, for boundary</param>
        private void randomize(int randomInt, int gridSize)
        {
            Random r = new Random();
            for (int i = 0; i < randomInt; i++)
            {
                Location randomSwap = blank.getAdjacentLocation(r.Next(0, 4));

                if (randomSwap.getRow() < gridSize && randomSwap.getColumn() < gridSize
                    && randomSwap.getRow() >= 0 && randomSwap.getColumn() >= 0)
                {
                    swap(randomSwap, blank);
                    blank = randomSwap;
                }
            }
        }

        /// <summary>
        /// Swaps two Locations
        /// </summary>
        /// <param name="swap1">A Location</param>
        /// <param name="swap2">Another Location</param>
        private void swap(Location swap1, Location swap2)
        {
            Tile temp = myGrid[swap1.getRow(), swap1.getColumn()];
            myGrid[swap1.getRow(), swap1.getColumn()] = myGrid[swap2.getRow(), swap2.getColumn()];
            myGrid[swap2.getRow(), swap2.getColumn()] = temp;

            myGrid[swap1.getRow(), swap1.getColumn()].setLocation(swap1);
            myGrid[swap2.getRow(), swap2.getColumn()].setLocation(swap2);
        }
    }
}

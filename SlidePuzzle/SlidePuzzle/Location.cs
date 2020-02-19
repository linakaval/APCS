using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidePuzzle
{
    class Location
    {
        private int row, column;
        public const int UP = 0;
        public const int RIGHT = 1;
        public const int DOWN = 2;
        public const int LEFT = 3;

        /// <summary>
        /// Constructs the location
        /// </summary>
        /// <param name="r"> row of the object </param>
        /// <param name="c"> column of the object </param>
        public Location(int r, int c)
        {
            row = r;
            column = c;

        }

        /// <summary>
        /// Gets the row value
        /// </summary>
        /// <returns> an int row </returns>
        public int getRow()
        {
            return row;
        }

        /// <summary>
        /// Gets the column value
        /// </summary>
        /// <returns> an int column </returns>
        public int getColumn()
        {
            return column;
        }

        /// <summary>
        /// Gets the location of nearby objects and sets a new location for the object
        /// </summary>
        /// <param name="direction"> the direction in which the object moves </param>
        /// <returns></returns>
        public Location getAdjacentLocation(int direction)
        {
            switch (direction)
            {
                case UP:    return new Location(row - 1, column);
                case RIGHT: return new Location(row, column + 1);
                case DOWN:  return new Location(row + 1, column);
                case LEFT:  return new Location(row, column - 1);
                default: return null;
            }
        }
    }
}

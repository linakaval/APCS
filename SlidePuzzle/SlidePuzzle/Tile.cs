using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidePuzzle
{
    class Tile
    {
        private Image myImage;
        private Location myLocation;
        private int mySize;
        private int myValue;


        /// <summary>
        /// Constructs a tile
        /// </summary>
        /// <param name="value"> The inherent value of the tile </param>
        /// <param name="tileSize"> Size of the tile </param>
        /// <param name="location"> Location of the tile </param>
        /// <param name="img"> Image of the tile </param>
        public Tile(int value, int tileSize, Location location, Image img)
        {
            myValue = value;
            myImage = img;
            myLocation = location;
            mySize = tileSize;
        }

        /// <summary>
        /// Get the location of the Tile
        /// </summary>
        /// <returns> a Location object </returns>
        public Location getLocation()
        {
            return myLocation;
        }

        /// <summary>
        /// Get the inherent value of the Tile, based on its order in the array
        /// </summary>
        /// <returns> an int value </returns>
        public int getValue()
        {
            return myValue;
        }

        /// <summary>
        /// Paints the Tile
        /// </summary>
        /// <param name="g"> the graphics object </param>
        public void paint(Graphics g)
        {
            g.DrawImage(myImage, myLocation.getColumn() * mySize, myLocation.getRow() * mySize);
        }

        /// <summary>
        /// Sets a new location for the Tile
        /// </summary>
        /// <param name="newLocation"></param>
        public void setLocation(Location newLocation)
        {
            myLocation = newLocation;
        }

    }
}

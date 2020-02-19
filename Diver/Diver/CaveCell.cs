using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver
{
    class CaveCell
    {
        private int myDepth;
        private Location myLocation;
        private Color myColor, originalColor, escapeColor;
        private int mySize;
        private Boolean isPartOfEscapeRoute;

        /// <summary>
        /// Makes a cave cell
        /// </summary>
        /// <param name="aDepth"> Depth value </param>
        /// <param name="location"> Location of the cell </param>
        /// <param name="aSize"> Size of the cell </param>
        /// <param name="aColor"> Color of the cell </param>
        /// <param name="anEscapeColor">The escape color of the cell </param>
        public CaveCell(int aDepth, Location location, int aSize, Color aColor, Color anEscapeColor)
        {
            myDepth = aDepth;
            myLocation = location;
            mySize = aSize;
            myColor = aColor;
            originalColor = aColor;
            escapeColor = anEscapeColor;
        }

        /// <summary>
        /// Gets the location of the cell
        /// </summary>
        /// <returns></returns>
        public Location getLocation()
        {
            return myLocation;
        }

        /// <summary>
        /// Gets the depth of the cell
        /// </summary>
        /// <returns></returns>
        public int getDepth()
        {
            return myDepth;
        }

        /// <summary>
        /// Sets the color of the cell
        /// </summary>
        /// <param name="escapeRoute"></param>
        public void setColor(bool escapeRoute)
        {
            isPartOfEscapeRoute = escapeRoute;
            if (isPartOfEscapeRoute)
            {
                myColor = escapeColor;
            }
            else
            {
                myColor = originalColor;
            }

        }

        /// <summary>
        /// Paints the cell
        /// </summary>
        /// <param name="g"> Graphics object </param>
        public void paint(Graphics g)
        {
            g.FillRectangle(new SolidBrush(myColor), myLocation.getColumn() * mySize, myLocation.getRow() * mySize, mySize, mySize);
            g.DrawRectangle(new Pen(Color.Black), myLocation.getColumn() * mySize, myLocation.getRow() * mySize, mySize, mySize);
            g.DrawString("" + myDepth, new Font("Arial", 13), new SolidBrush(Color.White), new Point(myLocation.getColumn() * mySize, myLocation.getRow() * mySize));
        }    
    }
}

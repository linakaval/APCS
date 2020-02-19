using System;
using System.Drawing;

public class APOval : APShape
{
    /// <summary>
    /// Default constructor for APOval
    /// </summary>
   public APOval() 
   {
   }

    /// <summary>
    /// Constructor that calls APShape constructor
    /// </summary>
    /// <param name="x1"> x value of first point </param>
    /// <param name="y1"> y value of first point </param>
    /// <param name="x2"> x value of second point </param>
    /// <param name="y2"> y value of second point </param>
    /// <param name="c"> color </param>
    public APOval( int x1, int y1, int x2, int y2, Color c)
        :base(x1, y1, x2, y2, c)
   { 

   }

    /// <summary>
    /// Draws the ellipse
    /// </summary>
    /// <param name="g"> Graphics object </param>
    public override void draw(Graphics g)
    {
        g.DrawEllipse(new Pen(getColor(), 2), getX1(), getY1(), (getX2() - getX1()), (getY2() - getY1()));
    }

}

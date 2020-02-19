using System;
using System.Drawing;

public class APBox : APShape
{
    /// <summary>
    /// Default constructor for APBox
    /// </summary>
   public APBox() 
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
	public APBox( int x1, int y1, int x2, int y2, Color c )
        :base(x1, y1, x2, y2, c)
   { 

   }

    /// <summary>
    /// Draws the rectangle
    /// </summary>
    /// <param name="g"> Graphics object </param>
    public override void draw(Graphics g)
    {
        g.DrawRectangle(new Pen(getColor(), 2), Math.Min(getX1(), getX2()), Math.Min(getY1(), getY2()), Math.Abs(getX1() - getX2()), Math.Abs(getY1() - getY2()));
    }
}

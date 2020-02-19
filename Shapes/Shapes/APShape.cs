using System.Drawing;

public abstract class APShape
{
    private int x1, x2, y1, y2;
    private Color myColor;

    /// <summary>
    /// Default constructor for APShape that sets everything to zero
    /// </summary>
    public APShape() 
    { 
        setX1( 0 );
        setX2( 0 );
        setY1( 0 );
        setY2( 0 );
		myColor = Color.Black;
    }

    /// <summary>
    /// Constructor that lets all the location values be set by setter methods
    /// </summary>
    /// <param name="x1"> x value of first point </param>
    /// <param name="y1"> y value of first point </param>
    /// <param name="x2"> x value of second point </param>
    /// <param name="y2"> y value of second point </param>
    /// <param name="c"> color </param>
    public APShape( int x1, int y1, int x2, int y2, Color c ) 
    { 
        setX1( x1 );
        setX2( x2 );
        setY1( y1 );
        setY2( y2 );
		setColor( c );
    }

    /// <summary>
    /// Sets the x value of first point
    /// </summary>
    /// <param name="x1"> x value of first point </param>
    public void setX1( int x1 ) { this.x1 = ( x1 >= 0 ? x1 : 0 ); }

    /// <summary>
    /// Sets the x value of second point
    /// </summary>
    /// <param name="x2"> x value of second point </param>
    public void setX2( int x2 ) { this.x2 = ( x2 >= 0 ? x2 : 0 ); }

    /// <summary>
    /// Sets the y value of first point
    /// </summary>
    /// <param name="y1"> y value of first point </param>
    public void setY1( int y1 ) { this.y1 = ( y1 >= 0 ? y1 : 0 ); }

    /// <summary>
    /// Sets the y value of second point
    /// </summary>
    /// <param name="y2"> y value of second point </param>
    public void setY2( int y2 ) { this.y2 = ( y2 >= 0 ? y2 : 0 ); }

    /// <summary>
    /// Sets the color of the shape
    /// </summary>
    /// <param name="c"> color of the shape </param>
	public void setColor(Color c) {this.myColor = c;}

    /// <summary>
    /// Gets the x value of first point
    /// </summary>
    /// <returns> x value of first point </returns>
    public int getX1() { return x1; }

    /// <summary>
    /// Gets the x value of second point
    /// </summary>
    /// <returns> x value of second point </returns>
    public int getX2() { return x2; }

    /// <summary>
    /// Gets the y value of first point
    /// </summary>
    /// <returns> y value of first point </returns>
    public int getY1() { return y1; }

    /// <summary>
    /// Gets the y value of second point
    /// </summary>
    /// <returns> y value of second point </returns>
    public int getY2() { return y2; }

    /// <summary>
    /// Gets the color of the shape
    /// </summary>
    /// <returns> color of the shape </returns>
	public Color getColor() { return myColor; }

    /// <summary>
    /// Parent method to draw a shape, does not have a method body
    /// </summary>
    /// <param name="g"> Graphics object</param>
    public abstract void draw(Graphics g); 

}

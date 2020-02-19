using System;
using System.Collections.Generic;
using System.IO; // Input-Output Library
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothSound
{
    class SoundSmoother
    {
        private double[] rawData;
        private double[] smoothData;
        private int myXInterval;
        private int myYInterval;
        private int myBaseLine;
        private Pen rawPen;
        private Pen smoothPen;


        /// <summary>
        /// Constructs a SoundSmoother object
        /// </summary>
        /// <param name="fileName">The name of the file that contains the sound frequency data</param>
        /// <param name="maxValues">The maximum number of frequency values to be processed</param>
        /// <param name="xScale">The amount of horizontal space between the points in the sound graph</param>
        /// <param name="yScale">The multiplier for scaling the points in the vertical direction</param>
        /// <param name="baseLine">The y-value for the bottom of the graph</param>
        public SoundSmoother(string fileName, int maxValues, int xScale, int yScale, int baseLine)
        {
            myXInterval = xScale;
            myYInterval = yScale;
            myBaseLine = baseLine;
            rawPen = Pens.Black;
            smoothPen = Pens.Red;
            loadData(fileName, maxValues);
        }
        /// <summary>
        /// Read the data from the file and store it in the array of raw data.
        /// Call this method from the constructor
        /// </summary>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="maxValues">The maximum number of frequency values to be processed</param>
        private void loadData(string fileName, int maxValues)
        {
            StreamReader sr = new StreamReader(fileName);
            rawData = new double[maxValues];

            int index = 0;
            while (!sr.EndOfStream && index < maxValues) //remember short circuit boolean
            {
                rawData[index] = Convert.ToDouble(sr.ReadLine());
                index++;
            }
            smoothData = (double[])rawData.Clone(); //use this to make sure that smoothData isn't assigned the same memory address
        }

        /// <summary>
        /// Builds an array of Point objects based on the frequency data.
        /// </summary>
        /// <param name="data">The array of the frequency data</param>
        /// <returns>An array of Points (x,y) which can then be used to graph the frequency data</returns>
        private Point[] getPoints(double[] data)
        {
            Point[] points = new Point[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                int x = (i * myXInterval);
                int y = (int)(myBaseLine - data[i] * myYInterval);
                points[i] = new Point(x, y);

            }
            return points;
        }

        public void smoothIt()
        {
            double[] temp = new double[smoothData.Length];

            temp[0] = (smoothData[0] + smoothData[1]) / 2;
            for (int i = 1; i < smoothData.Length - 1; i++)
            {
                temp[i] = (smoothData[i - 1] + smoothData[i] + smoothData[i + 1]) / 3;
            }
            temp[smoothData.Length - 1] = (smoothData[smoothData.Length - 2] + smoothData[smoothData.Length - 1]) / 2;

            smoothData = (double[]) temp.Clone();

        }

        public void paint(Graphics g)
        {
            if (smoothData != null)
            {
                g.DrawLines(smoothPen, getPoints(smoothData));
            }
            g.DrawLines(rawPen, getPoints(rawData));

        }

    }
}

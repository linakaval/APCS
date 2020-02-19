using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Snake : Pet //java = extends instead of colon
    {
        private int myLength;

        public Snake(string aName, int aLength)
            : base(aName)
        {
            //java = super(aName)
            myLength = aLength;
        }

        public override string ToString()
        {
            return base.ToString() + " I am " + myLength + " inches long."; //java = super.ToString();
        }

        public override string speak()
        {
            return "hiss!";
        }

        public override string move()
        {
            return "slither";
        }
    }
}

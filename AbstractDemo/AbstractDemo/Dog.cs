using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Dog : Pet
    {
        private int myWeight;

        public Dog(string aName, int aWeight)
        :base(aName)
        {
            myWeight = aWeight;
        }

        public override string ToString()
        {
            return base.ToString() + " I am " + myWeight + " pounds."; //java = super.ToString();
        }

        public override string speak()
        {
            return "bark!";
        }

        public override string move()
        {
            return "run";
        }

        public void doNothing()
        {

        }
    }
}

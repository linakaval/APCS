using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    abstract class Pet
    {
        private string myName;

        public Pet(string aName)
        {
            myName = aName;
        }

        public string getName()
        {
            return myName;
        }

        public override string ToString()
        {
            return "My name is " + myName + ".";
        }

        public abstract string speak();
        public abstract string move();

    }
}

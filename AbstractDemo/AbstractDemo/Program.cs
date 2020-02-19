using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Pet("foo"); → can't do that

            Dog d = new Dog("Nyquil", 123);
            Snake s = new Snake("McKain", 32);

            Pet[] p = new Pet[2];
            p[0] = d;
            p[1] = s;

            foreach (Pet item in p)
            {
                Console.WriteLine(item);
                Console.WriteLine("When I speak, I say " + item.speak());
                Console.WriteLine("When I move, I " + item.move());
            }
            
            
            //Pet p = s;
            //Console.WriteLine(p); run time error

            //Pet p = d;
            //Console.WriteLine(p);

            //d = p; → error = cannot implicitly assign p to d
            //d = (Dog)p;
            //Console.WriteLine(d);


        }
    }
}

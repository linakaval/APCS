using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibs
{
    class Program
    {
        private static int x = 1;
        private static int y = 1;
        private static int z = 0;

        private List<int> bunnies = new List<int>();
        static void Main(string[] args)
        {
            //Console.WriteLine(iterative(12));
            Console.WriteLine(recursive(45));
        }

        public static int iterative(int months)
        {
            Console.WriteLine("Enter a month: ");
            months = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < months; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }
            return z;
        }

        public static int recursive(int months)
        {
            if (months == 1)
            {
                return 2;
            }
            else if (months == 0)
            {
                return 1;
            }
            return recursive(months - 1) + recursive(months - 2);
        }
    }
}

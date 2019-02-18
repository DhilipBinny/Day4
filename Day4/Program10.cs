using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program10
    {
        static int b = 10;

        static void Main()
        {
            int a = 5;
            a = Increment(a);
            Console.WriteLine(a);

            IncrementB();
            Console.WriteLine(b);
        }
        //This method is not very good, because it cannot be reused
        //only increment variable b
        static void IncrementB()
        {
            b++;
        }
        //This method is better, because it's easier to reuse, it can take
        //any input and the output can be assigned to any variable
        static int Increment(int x)
        {
            return x + 1;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program5
    {
        static void Main()
        {
            for (int i=2; i<=100; i++)
            {
                if (isPrime(i)) //isPrime should return true if i is a prime number
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool isPrime(int x)
        {
            for(int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            //means it's not divisible by number from 2 to (x-1)
            return true;
        }


    }
}

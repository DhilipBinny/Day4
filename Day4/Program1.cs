using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program1
    {
        static void Main()
        {
            //general template for while loop

            bool stillRepeat = true;
            int numPrint = 0;
            stillRepeat = (numPrint < 3); // true;

            while (stillRepeat)
            {
                Console.WriteLine("Hello world");
                numPrint++;
                stillRepeat = (numPrint < 3);
            }
        }
    }
}

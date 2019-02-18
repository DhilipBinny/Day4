using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program6
    {
        static void Main()
        {
            int x1 = ReadUtility.ReadInteger("Please enter x1: ");
            int x2 = ReadUtility.ReadInteger("Please enter x2: ");
            int y1 = ReadUtility.ReadInteger("Please enter y1: ");
            int y2 = ReadUtility.ReadInteger("Please enter y2: ");
            Console.WriteLine($"({x1},{y1}) - ({x2},{y2})");
        }
    }
}

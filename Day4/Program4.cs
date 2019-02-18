using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program4
    {
        static void Main()
        {
            int[,] Marks = new int[3, 2];
            Marks[0, 0] = 35; Marks[0, 1] = 82;
            Marks[1, 0] = 67; Marks[1, 1] = 45;
            Marks[2, 0] = 62; Marks[2, 1] = 77;
            Print2DArray(Marks);

            Console.WriteLine();
            int[,] Marks2 = new int[,]
            {
                {35, 82 },
                {67, 45 },
                {62, 77 }
            };
            Print2DArray(Marks2);
        }

        public static void Print2DArray(int[,] array)
        {
            //for each of the rows do:
            //      for each of the columns do:
            //          Print the value
            //      Print new line

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write(array[row, col]);
                    if (col < array.GetLength(1) - 1)
                    {
                        //if not the last value in a row, print tab
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

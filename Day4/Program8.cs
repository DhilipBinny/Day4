using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program8
    {
        //Passing Array(ref type variable) by Value
        static void Main()
        {
            //A is an array, reference type 
            //A contains the reference to an array somewhere else in memory
            int[] A = new int[] { 1, 2, 3 };
            Program2.PrintArray(A); //1,2,3
            Increment(A);
            Program2.PrintArray(A); //1,2,3 or 2,3,4?
        }

        //pass by value: the reference held in A is copied over to X
        //X now contains the same reference to the same array referenced by A. 
        static void Increment(int[] X)
        {
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = X[i] + 1;
            }
        }
    }
}

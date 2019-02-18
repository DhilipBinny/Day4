using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program9
    {
        static void Main()
        {
            //Passing array (ref type) by reference
            int[] A = new int[3];
            Console.WriteLine(A.Length); //3
            ResizeArrayByVal(A, 5);
            Console.WriteLine(A.Length); //3 
            ResizeArrayByRef( ref A, 5);
            Console.WriteLine(A.Length); //5
        }

        //when we pass the array A by value, the reference contained in A 
        //get copied to X. X refer to the same address as A.
        static void ResizeArrayByVal(int[] X, int newSize)
        {
            X = new int[newSize];
            //X now refer to an array that has the size of newSize
            //X no longer refer to the same array as A.
        }

        //we pass A by reference to argument X.
        //X and A refer to the same value (X and A are the same variable)
        static void ResizeArrayByRef(ref int[] X, int newSize)
        {
            int[] oldArray = X;
            X = new int[newSize];

            //do something else...
            for (int i = 0; i < oldArray.Length; i++)
            {
                X[i] = oldArray[i];
            }
        }
    }
}

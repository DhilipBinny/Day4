using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program11
    {
        static void Main()
        {
            int[] A = new int[] { 1, 2, 3 };
            Program2.PrintArray(A);

            //we want all element of A to be (+1)
            ApplyOperation(A, Increment);
            Program2.PrintArray(A);

            //we want all element of A to be (*5)
            IntegerOps multiply5 = delegate (int y)
            {
                return y * 5;
            };
            ApplyOperation(A, multiply5);
            Program2.PrintArray(A);

            //we want all element of A to be raised to the power of 2
            ApplyOperation(A, (int w) => 
                                    { return w * w; });
            Program2.PrintArray(A);
        }

        //create as a method
        static int Increment(int z)
        {
            return z + 1;
        }

        delegate int IntegerOps(int x); //IntegerOps is the name of the delegate
        //data type that represent all methods that accept int and return int

        static void ApplyOperation (int [] X, IntegerOps ops)
        {
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = ops(X[i]); //apply the operation to X[i]
            }
        }
    }
}

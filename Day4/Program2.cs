using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program2
    {
        static void Main()
        {
            //int[] A = new int[5];
            //A[0] = 100;
            //A[1] = 200;
            //A[2] = 300;

            //for (int i=0; i < A.Length; i++)
            //{
            //    Console.WriteLine($"A[{i}] = {A[i]}");
            //    Console.WriteLine(i + "-" + A[i]);
            //}

            int[] B = new int[] { 100, 200, 300, 0, 0 };
            //int[] B = new int[]; //error
            //int[] B = new int[3] { 100, 200, 300, 0, 0 }; //error 

            Console.Write("B = ");
            PrintArray(B);

            int[] C;
            C = B;
            Console.Write("C = ");
            PrintArray(C);

            C[3] = 1000;
            Console.Write("B = "); PrintArray(B);
            Console.Write("C = "); PrintArray(C);

            int[] D = new int[5];
            D[2] = B[2];
            Console.Write("B = "); PrintArray(B);
            Console.Write("D = "); PrintArray(D);

            //make a copy
            int[] E = new int[B.Length]; //create an array with same size as B
            Array.Copy(B, E, B.Length);
            Console.Write("B = "); PrintArray(B);
            Console.Write("E = "); PrintArray(E);
            E[3] = 50000;
            Console.Write("B = "); PrintArray(B);
            Console.Write("E = "); PrintArray(E);


        }

        public static void PrintArray(int[] A)
        {
            Console.Write("{");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]}");
                if (i<A.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("}");
        }
    }
}

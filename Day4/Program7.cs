using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program7
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a); //6
            IncrementNumberByValue(a); //value of x is copied over as x argument.
            Console.WriteLine(a); //5
            IncrementNumberByRef(ref a);
            Console.WriteLine(a); //6

            Console.WriteLine($"{a},{b}");
            Swap(ref a, ref b);
            Console.WriteLine($"{a},{b}");
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }

        //Passing by value
        static int IncrementNumberByValue(int x) //not working as what it's supposed to do
        {
            return x+1;
        }

        //Passing by reference (address of the value)
        //Instead of copying the value of a into x, x refer to the variable a
        //the reference to a is copied as the reference of x
        static void IncrementNumberByRef(ref int x) 
        {
            x++;
        }

        static void IncrementNumberByOut(out int x)
        {
            //we cannot read x until we assign a value to x
            //x++; //over here we can't read x
            x = 0;
            x++; //over here, we can read the value of x.
        }
    }
}

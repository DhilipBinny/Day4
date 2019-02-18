using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program3
    {
        static void Main()
        {
            int[] array = new int[] { 3, 2, 1, 4, 0, 5 };
            Program2.PrintArray(array);

            //green arrow start from the beginning to the 2nd last element
            for (int green = 0; green < array.Length - 1; green++)
            {
                //red arrow start from one element after green arrow
                //and ends at the last element
                //last element : (red < array.Length) OR (red <= array.Length - 1)
                for (int red = green +1; red < array.Length; red++)
                {
                    //compare
                    //if values pointed by red arrow is smaller than values
                    //pointed by green arrow, we swap them
                    if (array[red] > array[green])
                    {
                        //swap
                        int temp = array[red];
                        array[red] = array[green];
                        array[green] = temp;
                    }
                }
            }
            Program2.PrintArray(array);

        }
    }
}

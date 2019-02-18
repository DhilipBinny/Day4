using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Quiz3
    {
        static void Main(string[] args)
        {
            string PIN = "123456";
            Console.WriteLine("Welcome to the Bank of ISS");

            string input="";
            for (int i=0; i < 3; i++)
            {
                //ask for input
                Console.Write("Enter PIN: ");
                input = Console.ReadLine();
                if (input != PIN && i !=2 )
                {
                    Console.WriteLine("Incorrect PIN. Please try again");
                } else
                {
                    break;
                }
            }
            if (input == PIN)
            {
                Console.WriteLine("PIN accepted.");
            } else
            {
                Console.WriteLine("Too many retries.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Quiz1
    {
        static void Main(string[] args)
        {
            string PIN = "123456";
            Console.WriteLine("Welcome to the Bank of ISS");
            string input;
            int numTries = 0; //user has not made any tries

            do
            {
                Console.Write("Enter PIN: ");
                input = Console.ReadLine();
                numTries++; //user has made another try to enter PIN
                if (input != PIN && numTries != 3)
                {
                    Console.WriteLine("Incorrect PIN. Please try again");
                }


            } while (input != PIN && numTries <3);

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

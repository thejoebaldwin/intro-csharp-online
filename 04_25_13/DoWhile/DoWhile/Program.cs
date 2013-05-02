using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            bool blnKeepAsking = true;

            do
            {
                Console.Write("Please enter a number:");
                string input = Console.ReadLine();
                Double dblInput = 0;
                blnKeepAsking = !Double.TryParse(input, out dblInput);
                if (blnKeepAsking)
                {
                    Console.WriteLine("That's not a number!");
                }

            } while (blnKeepAsking);
            Console.Write("Press any key to finish");
            Console.ReadLine();
        }
    }
}

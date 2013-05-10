using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Registrar
{
    class Program
    {
        static string[] Students = {"Tom", "Suzie", "Tina", "Jeff", "Paula" };
        static int[] Credits = { 96, 76, 22, 45, 110 };

        static void StudentMenu()
        {
            //Console.WriteLine("Hello World");
            Console.WriteLine("Please enter a number to view the credits of a student:");

            //int i = 0;
            //while (i < Students.Length)
            //{
            //    Console.WriteLine(i.ToString() + ":" + Students[i]);
            //    i++;
            //}

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + ":" + Students[i]);
            }
            string strInput = Console.ReadLine();
            int intInput = 0;
            Int32.TryParse(strInput, out intInput);
            //adjust for menu offset
            intInput = intInput - 1;
            if (intInput < 0 || intInput >= Students.Length)
            {
                Console.WriteLine("Please enter a valid menu option");
            }
            else
            {
                Console.WriteLine("You selected student:" + Students[intInput]);
                Console.WriteLine(Students[intInput] + " has " + Credits[intInput] + " credits.");
            }

            //Console.Write("Press Any Key To Continue");
            //Console.ReadKey();
        }


        static void Main(string[] args)
        {
            string strMenu = "";
            
            while (strMenu != "q")
            {
                StudentMenu();
                Console.Write("Enter any value to continue, 'q' to quit:");
                strMenu = Console.ReadLine();
            }
            //resume program flow
        }
    }
}

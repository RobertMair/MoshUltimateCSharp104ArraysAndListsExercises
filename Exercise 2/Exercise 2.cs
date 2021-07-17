using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    // Write a program and ask the user to enter their name. Use an array to reverse the name and
    // then store the result in a new string. Display the reversed name on the console.

    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.CursorVisible = false;
                string input;
                
                do
                {
                    Console.Write("\nPlease enter your name => ");
                    input = Console.ReadLine();
                    if(string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Please enter a valid name.");
                    }
                }
                while (string.IsNullOrWhiteSpace(input));

                char[] name = input.ToCharArray();
                Array.Reverse(name);

                string nameReversed ="";

                foreach (var chr in name)
                {
                    nameReversed += chr;
                }

                Console.WriteLine("Your name in reverse is: " + nameReversed);

                Console.WriteLine("\nPress any key to run again or X to exit => ");
                char rerun = Console.ReadKey(true).KeyChar;
                if (rerun == 'x' || rerun == 'X') loop = false;

            }

            Console.WriteLine("\nPress any key to exit program..");
            Console.ReadKey();
        }
    }
}
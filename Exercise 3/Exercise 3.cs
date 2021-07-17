using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3
{
    // Write a program and ask the user to enter 5 numbers. If a number has been 
    // previously entered, display an error message and ask the user to re-try.
    // Once the user successfully enters 5 unique numbers, sort them and display
    // the result on the console.

    class Program
    {
        
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.CursorVisible = false;
                List<int> userInput = new List<int>();

                do
                {
                    Console.Write("\nPlease enter number {0} => ", userInput.Count + 1);
                    var input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input) && Int32.TryParse(input, out var result))
                    {
                        if (!userInput.Contains(result))
                        {
                            userInput.Add(result);
                        }
                        else
                        {
                            Console.WriteLine("Number already entered, please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
                while (userInput.Count < 5);

                Console.Write("Your numbers in ascending order: ");
                userInput.Sort();
                foreach (int i in userInput)
                {
                    Console.Write(i + " ");
                }
                
                Console.WriteLine("\nPress any key to run again or X to exit => ");
                char rerun = Console.ReadKey(true).KeyChar;
                if (rerun == 'x' || rerun == 'X') loop = false;

            }

            Console.WriteLine("\nPress any key to exit program..");
            Console.ReadKey();
        }
    }
}
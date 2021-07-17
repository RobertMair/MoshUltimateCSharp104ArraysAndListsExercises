using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    // 4-	Write a program and ask the user to continuously enter a number or type "Quit" to exit.
    // The list of numbers may include duplicates. Display the unique numbers that the user has entered.

    class Program
    {
        
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.CursorVisible = false;
                string input;
                List<int> userInput = new List<int>();

                do
                {
                    Console.Write("\nPlease enter number {0} or type Quit to display unique numbers => ", userInput.Count + 1);
                    input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input) && Int32.TryParse(input, out var result))
                    {
                            userInput.Add(result);
                    }
                    else if (input.ToUpper() != "QUIT")
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
                while (input != null && input.ToUpper() != "QUIT");

                Console.Write("\nYour numbers in ascending order: ");
                userInput.Sort();
                foreach (int i in userInput)
                {
                    Console.Write(i + " ");
                }
                List<int> distinct = userInput.Distinct().ToList();
                Console.Write("\nYour UNIQUE numbers in ascending order: ");
                foreach (int i in distinct)
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
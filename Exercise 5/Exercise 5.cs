using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    // Write a program and ask the user to supply a list of comma separated numbers (e.g. 5, 1, 9, 2, 10).
    // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
    // otherwise, display the 3 smallest numbers in the list.

    class Program
    {

        static void Main(string[] args)
        {

            int total = 0;
            bool loop = true;
            List<int> userInput = new List<int>();

            while (loop)
            {
                bool validList = false;
                do
                {
                    Console.CursorVisible = false;
                    Console.Write("\nEnter a series of numbers separated by a comma (',') => ");
                    var input = Console.ReadLine();

                    userInput = input
                        .Split(',')
                        .Where(x => int.TryParse(x, out _))
                        .Select(int.Parse)
                        .ToList();

                    if (userInput.Count > 4)
                    {
                        validList = true;
                        userInput.Sort();
                        Console.Write("Valid numbers in ascending order are: ");
                        foreach (int i in userInput)
                        {
                            Console.Write(i + "  ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid list, please enter another one.");
                    }
                    
                } while (validList == false);

                userInput.Sort();
                Console.Write("\nThe three smallest numbers are: ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(userInput[i] + " ");
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

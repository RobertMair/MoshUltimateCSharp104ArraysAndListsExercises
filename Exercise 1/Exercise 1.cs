using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    // When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
    //  - If no one likes your post, it doesn't display anything. RM - changed this to "No one likes your post."
    //  - If only one person likes your post, it displays: [Friend's Name] likes your post.
    //  - If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
    //  - If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
    // Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
    // Depending on the number of names provided, display a message based on the above pattern.

    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.CursorVisible = false;
                string input;
                List<string> names = new List<string>();
                do
                {
                    Console.Write("\nEnter name number {0} (or press ENTER OK to continue) => ", names.Count+1);
                    input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input)) names.Add(input);
                }
                while (!string.IsNullOrWhiteSpace(input));
                
                switch (names.Count)
                {
                    case 0:
                        Console.WriteLine("\nNo one likes your post.");
                        break;
                    case 1:
                        Console.WriteLine("\n{0} likes your post.", names[0]);
                        break;
                    case 2:
                        Console.WriteLine("\n{0} and {1} and like your post.", names[0], names[1]);
                        break;
                    default:
                        string text = names.Count == 3 ? "other" : "others";
                        Console.WriteLine("\n{0}, {1} and {2} {3} like your post.", names[0], names[1], names.Count-2, text);
                        break;
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

using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1, 2, 3, and 4 code from previous assignments can be kept here

            // Part 5: List of Strings with Duplicates
            List<string> duplicateList = new List<string> { "apple", "banana", "cherry", "apple", "date", "banana" };

            Console.WriteLine("\nHere is the list of items:");
            foreach (string item in duplicateList)
            {
                Console.WriteLine(item);
            }

            // Ask the user to input text to search for in the list
            Console.Write("\nPlease enter text to search for in the list: ");
            string searchText = Console.ReadLine();

            // Flag to check if there were any matches
            bool matchFound = false;

            // Loop through the list and search for all occurrences of the text
            for (int i = 0; i < duplicateList.Count; i++)
            {
                if (duplicateList[i].Equals(searchText, StringComparison.OrdinalIgnoreCase)) // Case-insensitive comparison
                {
                    Console.WriteLine($"Match found at index {i}");
                    matchFound = true;
                }
            }

            // If no match was found, inform the user
            if (!matchFound)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            Console.ReadLine(); // Keep the console open
        }
    }
}
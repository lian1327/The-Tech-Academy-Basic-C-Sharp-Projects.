using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Objective 1
        // Create a list of integers. Ask the user for a number to divide each number in the list by.
        // Write a loop that takes each integer in the list, divides it by the number the user entered,
        // and displays the result to the screen.
        
        List<int> Numbers = new List<int>();
        int numberOfItems = 5; // You can set this to any number you want

        for (int i = 0; i < numberOfItems; i++)
        {
            Console.WriteLine($"Enter item number #{i + 1}:");

            // Read input and handle potential null or empty value
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out int number))
                {
                    Numbers.Add(number);
                    Console.WriteLine("Number added to list.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Decrement i to retry the current index
                }
            }
            else
            {
                Console.WriteLine("Input cannot be empty. Please enter a valid integer.");
                i--; // Decrement i to retry the current index
            }
        }

        Console.WriteLine("Enter a number to divide each item in the list by:");
        string divisorInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(divisorInput) && int.TryParse(divisorInput, out int divisor))
        {
            foreach (int num in Numbers)
            {
                Console.WriteLine($"{num} divided by {divisor} equals {num / (float)divisor}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Exiting program.");
        }

        // Prevent the console from closing immediately
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}

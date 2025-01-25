using System;
using System.Collections.Generic;

class Program 
{
    static void Main(string[] args)
    {
        static void string_req()
        {
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Display the array elements
            Console.WriteLine("Available fruits:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"{i}: {fruits[i]}");
            }

            // Ask the user to select an index
            Console.WriteLine("\nPlease enter an index (0 to 4):");
            int index = int.Parse(Console.ReadLine());

            // Display the string at the selected index
            if (index >= 0 && index < fruits.Length)
            {
                Console.WriteLine($"The fruit at index {index} is {fruits[index]}.");
            }
            else
            {
                Console.WriteLine("Invalid index. Please enter a value between 0 and 4.");
            }
        }

        static void IntArrayReq()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Display the array elements
            Console.WriteLine("Available numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i}: {numbers[i]}");
            }

            // Ask the user to select an index
            Console.WriteLine("\nPlease enter an index (0 to 4):");
            int index = int.Parse(Console.ReadLine());

            // Display the integer at the selected index
            if (index >= 0 && index < numbers.Length)
            {
                Console.WriteLine($"The number at index {index} is {numbers[index]}.");
            }
            else
            {
                Console.WriteLine("Invalid index. Please enter a value between 0 and 4.");
            }
        }


        List<string> WordsArray = new List<string>();

        
        Console.WriteLine("String Array");

        bool Start = true;
        while(Start)
        {
            Console.WriteLine("what word would you like to store in the array ");
            string word = Console.ReadLine();

            Console.WriteLine("Where would you like to store in the array, enter a number: ");
            int loc = int.Parse(Console.ReadLine());

            WordsArray.Insert(loc, word);

            Console.WriteLine("Do you wish to continue? (yes/no): ");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "yes")
            {
                Console.WriteLine("Continuing...");
                continue;
            }
            else
            {
                Console.WriteLine("--------");
                break;
            }
        }


    }
}
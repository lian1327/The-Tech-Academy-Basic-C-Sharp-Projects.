using System;
using Assignment14;

namespace Assignment14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.Write("Please enter a valid integer: ");
            }

            // Call the DivideByTwo method with the user's input
            MathOperations.DivideByTwo(userInput, out int dividedResult);

            // Display the result to the screen
            Console.WriteLine($"The result of dividing {userInput} by 2 is: {dividedResult}");

            // Example of calling the overloaded method with a float parameter
            float floatInput = 10.5f;
            MathOperations.DivideByTwo(floatInput, out float dividedFloatResult);
            Console.WriteLine($"The result of dividing {floatInput} by 2 is: {dividedFloatResult}");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}

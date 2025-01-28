using System;

namespace Assignment13
{
    // Create a class named MathOperations
    public class MathOperations
    {
        // Create a void method that takes two integers as parameters
        public void PerformOperation(int a, int b)
        {
            // Perform a math operation on the first integer (e.g., multiply it by 2)
            int result = a * 2;

            // Display the second integer to the screen
            Console.WriteLine($"The second integer is: {b}");

            // Optionally, display the result of the math operation
            Console.WriteLine($"The result of the math operation is: {result}");
        }
    }
}

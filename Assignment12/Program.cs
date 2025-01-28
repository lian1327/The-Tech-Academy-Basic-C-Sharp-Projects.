using System;
using Assignment12;

namespace Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MyClass
            MyClass myClass = new MyClass();

            // Ask the user to input the first number
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            // Ask the user to input the second number, if any
            Console.Write("Enter the second number (or press Enter to skip): ");
            string input = Console.ReadLine();

            int result;

            // Check if the user entered a second number
            if (string.IsNullOrEmpty(input))
            {
                // Call the method with only one parameter
                result = myClass.AddNumbers(num1);
            }
            else
            {
                // Call the method with two parameters
                int num2 = int.Parse(input);
                result = myClass.AddNumbers(num1, num2);
            }

            // Display the result
            Console.WriteLine($"The result is: {result}");
        }
    }
}

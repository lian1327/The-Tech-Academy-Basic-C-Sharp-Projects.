using System;
using Assignment13;

namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method in the class, passing in two numbers
            Console.WriteLine("Enter number one -->");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number one -->");
            int num2 = int.Parse(Console.ReadLine());

            mathOps.PerformOperation(num1, num2);

            // Call the method in the class, specifying the parameters by name
            mathOps.PerformOperation(num1, num2);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}

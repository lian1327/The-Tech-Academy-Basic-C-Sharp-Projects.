using System;
using Assignment10;

namespace Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing class instance");
            MathClass mc = new MathClass(75, 33);

            Console.WriteLine($"Sum: {mc.getAdd()}");
            Console.WriteLine($"Quotient: {mc.getQuotient()}");

            Console.WriteLine("Factorial \nInput a number --> ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Factorial of: {number} is {mc.Factorial(number)}");

        }
    }
}

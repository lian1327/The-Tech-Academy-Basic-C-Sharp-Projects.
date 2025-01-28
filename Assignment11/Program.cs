using System;
namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Arithmetic Operation with OOP Implementation");
            Console.WriteLine("Enter number one --> ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number two --> ");
            int num2 = int.Parse(Console.ReadLine());

            MathClass mc = new MathClass(num1,num2);

            Console.WriteLine($"{num1} + {num2} is equals to {mc.getAdd()}");
            Console.WriteLine($"{num1} - {num2} is equals to {mc.getSub()}");

            //Taking up Float numbers
            Console.WriteLine("Enter numbers in Decimal form\nNumber one -->");
            float d1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Number two --> ");
            float d2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{d1} + {d2} is equals to {mc.getAddFloat(d1, d2)}");
            Console.WriteLine($"{d1} - {d2} is equals to {mc.getSubFloat(d1, d2)}");
            Console.WriteLine($"The Factorial of {d1} is {mc.getFactorialFloat(d1)}");
        }
    }
}
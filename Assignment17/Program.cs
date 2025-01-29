using System;

namespace Assignment17
{
    class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Employee and set its properties
        Employee employee = new Employee { Name = "John", Position = "Software Developer" };

        // Use polymorphism to create an object of type IQuittable
        IQuittable quittableEmployee = employee;

        // Call the Quit method on the IQuittable object
        quittableEmployee.Quit();

        // Keep the console window open
        Console.ReadLine();
    }
}
}
using System;
using System.Collections.Generic;
using Assignment19;

namespace Assignment19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type string as its generic parameter
            Employee<string> employeeWithStrings = new Employee<string>
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Things = new List<string> { "Laptop", "Notebook", "Pen" } // Assign a list of strings to the Things property
            };

            // Instantiate an Employee object with type int as its generic parameter
            Employee<int> employeeWithInts = new Employee<int>
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Things = new List<int> { 101, 202, 303 } // Assign a list of integers to the Things property
            };

            // Loop through the Things property of employeeWithStrings and print each item to the console
            Console.WriteLine("Employee with strings:");
            foreach (var thing in employeeWithStrings.Things)
            {
                Console.WriteLine(thing);
            }

            // Loop through the Things property of employeeWithInts and print each item to the console
            Console.WriteLine("\nEmployee with ints:");
            foreach (var thing in employeeWithInts.Things)
            {
                Console.WriteLine(thing);
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}

using System;

namespace Assignment18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded "==" operator
            bool areEqual = employee1 == employee2;

            // Display the comparison result
            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual}");

            // Create another Employee object with the same Id as employee1
            Employee employee3 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

            // Compare employee1 and employee3 using the overloaded "==" operator
            areEqual = employee1 == employee3;

            // Display the comparison result
            Console.WriteLine($"Are employee1 and employee3 equal? {areEqual}");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}

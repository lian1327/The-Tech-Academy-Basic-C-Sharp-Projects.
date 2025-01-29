using System;
using Assignment20;
using System.Collections.Generic;
using System.Linq;

namespace Assignment20
{
    public class Program
    {
        public static void Main()
        {
            // Create a list of at least 10 employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Black" },
                new Employee { Id = 4, FirstName = "Anna", LastName = "Williams" },
                new Employee { Id = 5, FirstName = "Bill", LastName = "Turner" },
                new Employee { Id = 6, FirstName = "Sam", LastName = "Johnson" },
                new Employee { Id = 7, FirstName = "Susan", LastName = "Clark" },
                new Employee { Id = 8, FirstName = "Mike", LastName = "Brown" },
                new Employee { Id = 9, FirstName = "Carol", LastName = "Davis" },
                new Employee { Id = 10, FirstName = "Nina", LastName = "White" }
            };

            // Using a foreach loop to create a new list of employees with the first name "Joe"
            List<Employee> joesForeach = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesForeach.Add(employee);
                }
            }

            // Display the list created using foreach loop
            Console.WriteLine("Employees with the first name 'Joe' (using foreach loop):");
            foreach (var joe in joesForeach)
            {
                Console.WriteLine($"Id: {joe.Id}, First Name: {joe.FirstName}, Last Name: {joe.LastName}");
            }

            // Using a lambda expression to create a new list of employees with the first name "Joe"
            List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Display the list created using lambda expression
            Console.WriteLine("\nEmployees with the first name 'Joe' (using lambda expression):");
            foreach (var joe in joesLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, First Name: {joe.FirstName}, Last Name: {joe.LastName}");
            }

            // Using a lambda expression to create a list of employees with an Id number greater than 5
            List<Employee> idGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

            // Display the list of employees with an Id number greater than 5
            Console.WriteLine("\nEmployees with an Id number greater than 5:");
            foreach (var employee in idGreaterThanFive)
            {
                Console.WriteLine($"Id: {employee.Id}, First Name: {employee.FirstName}, Last Name: {employee.LastName}");
            }
        }
    }
}
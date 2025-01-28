using System;
using Assignment15;

namespace Assignment15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1
            };

            // Call the SayName() method from the Person class on the Employee object
            employee.SayName();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}

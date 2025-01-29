using System;
using Assignment16;
// Define a class called Employee that inherits from the Person class
namespace Assignment16{
    class Program
    {
    static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee employee = new Employee();

            // Set the first name and last name of the employee
            Console.WriteLine("Enter student name ---> ");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter student name ---> ");
            string lname = Console.ReadLine();


            employee.FirstName = fname;
            employee.LastName = lname;

            // Call the SayName() method on the Employee object
            employee.SayName();

            // The output will be: "Employee Name: Sample Student"
        }
    }

}


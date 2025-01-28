using System;
using Assignment15;

namespace Assignment15
{
    // Create a class called Person
    public class Person
    {
        // Properties for first name and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to say the person's full name
        public void SayName()
        {
            // Write the person's full name to the console
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}

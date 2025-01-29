namespace Assignment17
{
    public class Employee : IQuittable
    {
        // Employee properties (e.g., Name, Position, etc.)
        public string Name { get; set; }
        public string Position { get; set; }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            // Display a message indicating the employee has quit
            Console.WriteLine($"{Name} has quit their position as {Position}.");
        }

    }
}
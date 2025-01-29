namespace Assignment16
{
    public class Employee : Person
    {
        // Implement the abstract method SayName() from the Person class
        public override void SayName()
        {
            // Print the full name of the employee to the console
            Console.WriteLine($"Employee Name: {FirstName} {LastName}");
        }
    }
}


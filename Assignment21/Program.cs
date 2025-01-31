using System;

public class Program
{
    public static void Main()
    {
        // Prints the current date and time to the console
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine("Current date and time: " + currentDateTime);

        // Asks the user for a number
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();
        int hours;
        
        // Ensures the user input is a valid integer
        while (!int.TryParse(userInput, out hours)) 
        {
            Console.Write("Please enter a valid number: ");
            userInput = Console.ReadLine();
        }

        // Calculates the exact time it will be in X hours
        DateTime futureDateTime = currentDateTime.AddHours(hours);
        Console.WriteLine($"In {hours} hours, the exact time will be: " + futureDateTime);
    }
}

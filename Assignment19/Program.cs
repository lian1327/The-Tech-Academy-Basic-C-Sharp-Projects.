using System;

namespace Assignment19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            while (true)
            {
                // Use a try/catch block to handle potential errors
                try
                {
                    // Read the user's input and convert it to the DaysOfWeek enum type
                    string userInput = Console.ReadLine();
                    DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                    // Print the current day to the console
                    Console.WriteLine($"You have entered: {currentDay}");
                    Console.WriteLine("Thank you.");
                    break;
                }
                catch (Exception)
                {
                    // If an error occurs, print an error message to the console
                    Console.WriteLine("Please enter an actual day of the week.");
                    continue;
                }
            }
            
            Console.ReadLine();
            
        }
    }
}

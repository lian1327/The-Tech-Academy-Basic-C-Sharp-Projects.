using System;

namespace TryCatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for their age
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();
                
                // Convert the input to an integer
                int age = int.Parse(input);
                
                // Check if the age is zero or negative
                if (age <= 0)
                {
                    // Throw an exception if the age is zero or negative
                    throw new ArgumentException("Age must be a positive number.");
                }

                // Calculate the year the user was born
                int currentYear = DateTime.Now.Year;
                int yearBorn = currentYear - age;

                // Display the year the user was born
                Console.WriteLine("You were born in the year: " + yearBorn);
            }
            catch (FormatException)
            {
                // Handle exception if the input is not a valid number
                Console.WriteLine("Error: The input must be a valid number.");
            }
            catch (ArgumentException ex)
            {
                // Handle exception if the age is zero or negative
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception)
            {
                // Handle any other exceptions
                Console.WriteLine("An unexpected error occurred.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

// See https://aka.ms/new-console-template for more information
using System;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Welcome to Assignment 3 ");
        Console.WriteLine("What is your age? ");
        int age = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Have you ever had a DUI ?  (Answer the question using true or false) ");
        bool dui = bool.Parse(Console.ReadLine());

        Console.WriteLine("How many speeding tickets do you have?");
        int tickets = int.Parse(Console.ReadLine());

        Console.WriteLine(" Assessing Qualifications .... ");
        Thread.Sleep(1000);

        bool result = (age > 15 && dui == false && tickets <= 3) ;
        if (result)
        {
            Console.WriteLine($"{result.ToString()}");
            Console.WriteLine("You are Qualified for the role ")

        }
        else
        {
            Console.WriteLine($"{result.ToString()}");
            Console.WriteLine("You are UnQualified for the role.")
        }

// Applicants must be over 15 years old.

// Applicants must not have any DUI’s.

// Applicants must not have more than 3 speeding tickets.

// Print the result of the boolean expression created from the above business rules.  

    }
}

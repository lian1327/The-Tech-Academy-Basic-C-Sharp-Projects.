using System;

public class Program
{
    // Create a const variable
    public const int ConstVariable = 42;

    public Program() : this("Default Value")
    {
        // This constructor is chained to the one below
    }

    public Program(string value)
    {
        Console.WriteLine("Constructor with value: " + value);
    }

    public void Display()
    {
        // Create a variable using the keyword “var”
        var varVariable = 100;

        Console.WriteLine("Const variable: " + ConstVariable);
        Console.WriteLine("Var variable: " + varVariable);
    }

    public static void Main()
    {
        // Create an instance of the Example class using the parameterless constructor
        Program example1 = new Program();

        // Create an instance of the Example class using the parameterized constructor
        Program example2 = new Program("Custom Value");

        // Display the values of the variables
        example1.Display();
        example2.Display();
    }
}

// See https://aka.ms/new-console-template for more information
using System;

class TestProgram
{
    static void Main()
    {
        //Objective #1
        Console.WriteLine("Anonymous Income Comparison Program");

        //Objective #2  - Person 1 
        Console.WriteLine("Person 1 Information ");
        Console.WriteLine("Hourly Rate ---> ");
        float rate1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Hours Worked per Weak ---> ");
        float hours1 = float.Parse(Console.ReadLine());

        //Objective #2   - Person 2 
        Console.WriteLine("Person 2 Information ");
        Console.WriteLine("Hourly Rate ---> ");
        float rate2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Hours Worked per Weak ---> ");
        float hours2 = float.Parse(Console.ReadLine());

        // Annual Computation, there is exactly 52 weeks in a year 
        float p1_annual = (float)Math.Round((rate1 * hours1) * 52);

        Console.WriteLine("Annual salary of Person 1: ");
        // Format the number with commas and two decimal places
        string p1_salary = p1_annual.ToString("N2");
        Console.WriteLine($"{p1_salary}");

        float p2_annual = (float)Math.Round((rate2 * hours2) * 52);

        Console.WriteLine("Annual salary of Person 2: ");
        // Format the number with commas and two decimal places
        string p2_salary = p2_annual.ToString("N2");
        Console.WriteLine($"{p2_salary}");

        //Last Objective 
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        if (p1_annual >= p2_annual)
        {
            Console.WriteLine($"{p1_annual > p2_annual}");
        }
        else 
        {
            Console.WriteLine($"{p1_annual > p2_annual}");
        } 
    }
}

// See https://aka.ms/new-console-template for more information
using System;

class TestProgram{
    static void Main()
    {
        Console.WriteLine("<<<<<<<<<<<  The Tech Academy >>>>>>>>>>>>>>");
        Console.WriteLine("Student Daily Report");
        //name
        Console.WriteLine("What is your Name .? ");
        string name = Console.ReadLine();

        //course
        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();

        //page
        Console.WriteLine("What page are you on?");
        int page = int.Parse(Console.ReadLine());

        //Help
        Console.WriteLine("Do you need help with anyhing? Please answer with True or False.");
        bool help = bool.Parse(Console.ReadLine());

        //Experience
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string experiences = Console.ReadLine();

        //Feedback
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        //hours
        Console.WriteLine("How many hours did you study today?");
        int hrs = int.Parse(Console.ReadLine());

        //Printing the inputs using concatenation and string formatting
        string msg = @$"Hi, {name} here, enrolled in the {course} Training Course 
        to which I'm currenly at page {page}. {help}, any help right now.
        So far, I'm having a lot of fun finishing the course ,  
        - I experience {experiences}.
        For me it would be nice if I could {feedback}. 
        Right now I'm at page {page}. 
        Thank you. ";

        //FINAL OUTPUT
        Console.WriteLine(msg);
    }
}
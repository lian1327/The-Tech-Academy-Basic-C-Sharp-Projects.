using System; 
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        //Concatenation
        Console.WriteLine("type anything ---> ");
        string word1 = Console.ReadLine();

        Console.WriteLine("type anything ---> ");
        string word2 = Console.ReadLine();

        Console.WriteLine("type anything ---> ");
        string word3 = Console.ReadLine();

        //Concatenating three strings
        string new_word = word1 + word2 + word3;

        Console.WriteLine("Which of the following would you like to upper case \n1 - word1, \n2- word2, \n3- word3\n Type your choice here -> ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine($"Converting {word1} to UPPERCASE would result to {word1.ToUpper()}");
        }

        else if (choice == 2)
        {
            Console.WriteLine($"Converting {word2} to UPPERCASE would result to {word2.ToUpper()}");
        }

        else if (choice == 3)
        {
            Console.WriteLine($"Converting {word3} to UPPERCASE would result to {word3.ToUpper()}");
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }

        StringBuilder sb = new StringBuilder();

        bool docontinue = true;
        Console.WriteLine("Using String builder to create a paragraph");
        while (docontinue)
        {
            Console.WriteLine("Please input any phrase or text ");
            string phrase = Console.ReadLine();

            sb.Append(phrase);
            Console.WriteLine("Do you wish to continue (yes / no )? ");
            string ans = Console.ReadLine();

            if (ans.ToLower() == "yes")
            {
                Console.WriteLine("\nContinuing\n");
                continue;
            }
            else
            {
                Console.WriteLine(" ------------------");
                break;
            }
        }

        string paragraph = sb.ToString();

        Console.WriteLine($"The collected paragraph is {paragraph}");
        
    }
    
}


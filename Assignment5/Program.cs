using System;

class Program
{
    static void Main()
    {
        // Do a boolean comparison using a while statement.

        bool do_continue = true;
        int whilerun = 0;
        int dowhile_counter = 0;
        //while loop comparison 
        while(do_continue)
        {
            Console.WriteLine("Do you wish to continue running this program? (yes/no)");
            string ans = Console.ReadLine();

            if (ans.ToLower() == "yes")
            {
                Console.WriteLine("Running");
                whilerun++;
                continue;
            }
            else
            {
                Console.WriteLine($"Stopping, while loop for {whilerun} times ");
                break;
            }
        }
        bool dow_continue = true;

        //Do while loop comparison
        do{
            Console.WriteLine("This is a do while loop, which mean it would run atleast once before evaluating the conditional expression");
            
            Console.WriteLine("Do you wish to continue, press 1 otherwise press any keys to terminate");
            int ansd = int.Parse(Console.ReadLine());
            if (ansd == 1)
            {
                Console.WriteLine("Running");
                dowhile_counter++;
                continue;
            }
            else
            {
                Console.WriteLine($"Stopping, dowhile loop for {dowhile_counter} times ");
                break;
            }
        }while(dow_continue);

    }
}
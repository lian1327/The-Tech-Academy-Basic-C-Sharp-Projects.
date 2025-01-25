using System;

class Program
{
    static void Main(string[] args) 
    {
       // Define a list of strings with at least two identical strings
        List<string> stringList = new List<string> { "A", "B", "C", "D", "C" };

        // Create a HashSet to keep track of seen strings
        HashSet<string> seenStrings = new HashSet<string>();

        // Loop through each item in the list
        foreach (string item in stringList)
        {
            // Check if the item has already been seen
            if (seenStrings.Contains(item))
            {
                // Print message if the item is a duplicate
                Console.WriteLine($"{item} - this item is a duplicate");
            }
            else
            {
                // Add the item to the set of seen strings
                seenStrings.Add(item);
                // Print message if the item is unique
                Console.WriteLine($"{item} - this item is unique");
            }
        }

    }
}
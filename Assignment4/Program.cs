using System;

class Program 
{
    static void Main()
    {
        
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        Console.WriteLine("Please enter the package weight:");
        float inputWeight = float.Parse(Console.ReadLine());

        if (inputWeight < 50)
        {
            Console.WriteLine("Please enter the package Width:");
            int inputWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int inputHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int inputLength = int.Parse(Console.ReadLine());

            int dimension = inputWidth + inputHeight + inputLength;

            if (dimension > 50) 
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                float price = ((inputWidth * inputHeight * inputLength) * inputWeight) / 100 ;
                string formattedPrice =  price.ToString("N2");
                Console.WriteLine($"Your estimated total for shipping this package is: ${formattedPrice}");
                Console.WriteLine("Thank you!");
            } 
        }
        else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }








    }
}
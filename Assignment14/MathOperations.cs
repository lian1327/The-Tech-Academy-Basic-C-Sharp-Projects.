using System;

namespace Assignment14
{
    // Declare the class as static
    public static class MathOperations
    {
        // Create a void method that divides the data passed to it by 2 and outputs the result
        public static void DivideByTwo(int input, out int result)
        {
            result = input / 2;
        }

        // Overload the DivideByTwo method to accept float parameters
        public static void DivideByTwo(float input, out float result)
        {
            result = input / 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{

    public class FraudException : Exception // Inherit the Exception class
    {
        public FraudException() // Define a method called FraudException
            : base() { } // Inherit the base classes (Exception) constructor

        public FraudException(string message) // Overload the FraudException method and add a parameter for a string message
            : base(message) { } // Inherit the base classes (Exception) constructor but this version has the string parameter
    } // End FraudException CLASS

} // End Casino NAMESPACE
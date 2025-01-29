using System;
using System.Collections.Generic;

namespace Assignment19
{
    // Define the Employee class with a generic type parameter T
    public class Employee<T>
    {
        // Properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Property called Things, which is a generic list of type T
        public List<T> Things { get; set; }
    }
}


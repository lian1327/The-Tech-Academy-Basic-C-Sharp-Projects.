using System;

namespace Assignment18
{
    // Define the Employee class
    public class Employee
    {
        // Properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator to compare Employee objects by their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both employees are null or if one of them is null
            if (ReferenceEquals(emp1, emp2)) return true;
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null)) return false;

            // Compare the Id properties of the two employees
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator to compare Employee objects by their Id property
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override the Equals method to provide custom equality comparison
        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                var emp = (Employee)obj;
                return this.Id == emp.Id;
            }
            return false;
        }

        // Override the GetHashCode method to match the custom equality comparison
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;

namespace TwentyOne
{

    /* This class will map one-to-one with our Exceptions table in our database with each property matching a column in the table */

    public class ExceptionEntity
    {
        /* PROPERTIES */ 

        public int Id { get; set; } // The primary key of the Exceptions table and the id column
        public string ExceptionType { get; set; } // The ExceptionType column from the exceptions table
        public string ExceptionMessage { get; set; } // The ExceptionMessage column from the exceptions table
        public DateTime TimeStamp { get; set; } // The TimeStamp column from the exceptions table

    } // End ExceptionEntity Class

} 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{

    public class TwentyOneDealer : Dealer 
    {
        /* PROPERTIES */

        private List<Card> _hand = new List<Card>(); // Instance a private list of the Card class called _hand, this ensure we already have an empty list
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } // A list of card objects to represent the Players hand, points to the private instance _hand
        public bool Stay { get; set; } // A boolean variable to represent if the dealer wants to stay
        public bool isBusted { get; set; } // A boolean variable to represent if the dealer has gone bust

    } 

} 
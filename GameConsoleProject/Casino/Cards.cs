using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card // Define an Struct object called Card and make it public so other programs can use it.
    {
        /* PROPERTIES */

        public Suit Suit { get; set; } // A Suit value to represent the Suit property of a playing card
        public Face Face { get; set; } // A Face value to represent the Face property of a playing card

        public override string ToString() // Override the Card class ToString() method
        {
            return string.Format("{0} of {1}", Face, Suit); // When the ToString() method is called we output the Face and Suit of the current instance of the Card Class
        }
    } // End Card CLASS Definition

    public enum Suit // Declare an enum called Suit with the following four values 
    { 
        Clubs,
        Diamonds,
        Hearts,
        Spades
    } // End ENUM Suit

    public enum Face // Declare an enum called Face with the following thirteen values
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    } // End ENUM Face

} // End Casino NAMESPACE
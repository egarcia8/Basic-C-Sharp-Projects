using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        //the card class has property of data type string called Suit and you can get or set this property
        //it is public to be accessible to other parts of the program
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}

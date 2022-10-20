using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Card card = new Card() { Face = "King", Suit = "Spades" };  //object initialization
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string> { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();

            //Console.ReadLine();
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;
            //game -= player;

            //Player<Card> player = new Player<Card>(); //generics example
           
            Deck deck = new Deck();  //here instantiated the object deck
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //adding to the list Hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); //writing what card is added
            Console.WriteLine(card);
            //adds cards dealt to text file, true indicates that you want to append some text to the file
            using (StreamWriter file = new StreamWriter(@"C:\Users\egarc\Logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now); //can use to log exactly when something happened
                file.WriteLine(card);
            } //using statement allows for it to be disposed from memory when done
                Deck.Cards.RemoveAt(0); //removing card from hand
        }
    }
}

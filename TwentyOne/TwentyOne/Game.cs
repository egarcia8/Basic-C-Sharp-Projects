using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //making abstract prevents it from being instantiated, helps keep control of code
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //abstract requires any class inherting this class to define this method
        public virtual void ListPlayers() //virtual means this method is inherited but has ability to be overridden
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}

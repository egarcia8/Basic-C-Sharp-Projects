using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game //making abstract prevents it from being instantiated, helps keep control of code
    {
        // these next two together are the same as a get, set 
        private List<Player> _players = new List<Player>(); //ensures a list is instantiated empty list
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } } //if you wanted to get Players it would return _players, if you wanted to set Players it would set _players to value 
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
       

        public abstract void Play(); //abstract requires any class inherting this class to define this method
        
        public virtual void ListPlayers() //virtual means this method is inherited but has ability to be overridden
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}

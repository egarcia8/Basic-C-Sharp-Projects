using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers() //inherited from virtual method
        {
            Console.WriteLine("21 Players:"); //added customization
            base.ListPlayers(); //inherited from game class
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}

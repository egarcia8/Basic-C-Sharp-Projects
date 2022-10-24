using System;
using Casino;
using Casino.TwentyOne;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text."; //adds text to a text file, used to log
            //File.WriteAllText(@"C:\Users\egarc\Logs\log.txt", text);

            //string text = File.ReadAllText(@"C:\Users\egarc\Logs\log.txt"); //this reads the text

            DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);
            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;


            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid(); //creates a Guid - global unique identifier
                using (StreamWriter file = new StreamWriter(@"C:\Users\egarc\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id); 
                }
                Game game = new TwentyOneGame(); //example of polymorphism object Game but also TwentyOneGame to expose overloaded operators
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now"); //did not use else statement so that this could apply to both
            Console.ReadLine();                                                    //the while loop and the if statement


        }

        
    }
}

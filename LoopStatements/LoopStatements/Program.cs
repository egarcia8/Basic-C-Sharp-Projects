using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 0;
            while (myNumber < 10)
            {
                Console.WriteLine(myNumber);
                myNumber++;
            }
           


            Console.WriteLine("Guess my favorite number.");
            int number = Convert.ToInt32(Console.ReadLine());
            int favNum = 15;
            bool isGuessed = number == favNum;
           

            do
            {
                switch(number)
                {
                    case 14:
                        Console.WriteLine("Close! Try Again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 15:
                        Console.WriteLine("That is correct! 15 is my favorite number");
                        Console.ReadLine();
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("That is not correct. Please try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);
            
        }   
    }
}

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
            int myNumber = 0; //decalred int variable named myNumber and assigned it to 0.
            while (myNumber < 10) //initiated a while loop that will run while myNumber is less than 10/
            {
                Console.WriteLine(myNumber); //myNumber will print to screen
                myNumber++; //my number will increment by 1
            } //this loop ends when the number gets to 9 because that is the last number less than 10
           


            Console.WriteLine("Guess my favorite number."); //print instruction to screen.
            int number = Convert.ToInt32(Console.ReadLine()); //converts number input by user to int and assigns it to the declared in varaible number
            int favNum = 15; //declares int variable favNum and assigns 15 to it
            bool isGuessed = number == favNum; //declares the bool variable isGuessed and sets it to true if number = favNum
           

            do //initiates do while loop
            {
                switch(number) //uses the expression number to begin switch case
                {
                    case 14: //if number is = 14 then the following block of code executes
                        Console.WriteLine("Close! Try Again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break; //exits out of switch loop

                    case 15: //if number is = 15 then the following block of code executes
                        Console.WriteLine("That is correct! 15 is my favorite number");
                        Console.ReadLine();
                        isGuessed = true; //evaulates variable to true to exit out of do while loop
                        break;
                    default: //if neither of the other two cases are met this run the following block of code
                        Console.WriteLine("That is not correct. Please try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed); //do while loop will run while isGuessed is false
            
        }   
    }
}

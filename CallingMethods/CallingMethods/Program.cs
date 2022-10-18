using System;
using System.Collections.Generic;
using System.Linq;


namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for number to do math opertaions on
            Console.WriteLine("Enter a number greater than 10 to display our math operations");
            int userInput = Convert.ToInt32(Console.ReadLine()); //declare a integer variable named userInput
                                                                 //assigning the userInput converted to an integer to it

            if (userInput > 10)//if the number provided is greater than 10 the methods are called
            {
                Console.WriteLine("Your number plus 10 equals: " + Operations.Add(userInput));
                Console.WriteLine("Your number times 10 equals: " + Operations.Multiply(userInput));
                Console.WriteLine("Your number minus 10 equals: " + Operations.Subtract(userInput));
            }
            else //if number is 10 or less the message will display on screen
            {
                Console.WriteLine("That number is not greater than 10.");
            }
           
            Console.ReadLine();
        }

       
    }
}

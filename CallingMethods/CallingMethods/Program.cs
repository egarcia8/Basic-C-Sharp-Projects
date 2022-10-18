using System;
using System.Collections.Generic;
using System.Linq;


namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number greater than 10 to display our math operations");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput > 10)
            {
                Console.WriteLine("Your number plus 10 equals: " + Operations.Add(userInput));
                Console.WriteLine("Your number times 10 equals: " + Operations.Multiply(userInput));
                Console.WriteLine("Your number minus 10 equals: " + Operations.Subtract(userInput));
            }
            else
            {
                Console.WriteLine("That number is not greater than 10.");
            }
           
            Console.ReadLine();
        }

       
    }
}

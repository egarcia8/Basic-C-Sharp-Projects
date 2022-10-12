using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Enter the package weight."); //user is prompted to enter weight
            int packWeight = Convert.ToInt32(Console.ReadLine()); //int variable packWeight declared and user input convert to integer is assigned to variable

            if (packWeight > 50) // if condition states if packWeight is greater than 50 the error message will display
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day!");
                return; //the program ends
            }
            else
            {
                Console.WriteLine("Please enter the package width."); //else statement will continue asking user for more dimensions
            }

            int packWidth = Convert.ToInt32(Console.ReadLine()); //int variable packWidth declared and user input convert to integer is assigned to variable

            Console.WriteLine("Please enter the height of the package.");
            int packHeight = Convert.ToInt32(Console.ReadLine()); //int variable packHeight declared and user input convert to integer is assigned to variable

            Console.WriteLine("Please enter the length of the package.");
            int packLength = Convert.ToInt32(Console.ReadLine()); //int variable packlength declared and user input convert to integer is assigned to variable
            //calculation for quote
            //decimal variable packQuote declared and is assigned to the calculation for shipping after it is converted to decimal
            decimal packQuote = Convert.ToDecimal(packHeight * packWidth * packLength * packWeight) / 100m;

            if (packWidth + packHeight + packLength > 50) //if condition states if dimensions are greater than 50 an error message will display
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                
            }
            else //else condition states the shipping quote
            {
                Console.WriteLine("\nYour estimated total for shipping this pacakge is: $" + packQuote.ToString("0.00")); //string concatenated with variable packQuote that is converted to string to show two decimal places
            }

            Console.WriteLine("\nThank you!");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");

            //print question to screen, declare variable and assign answer converted to integer to variable userAge
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            //print question to screen, declare variable and assign answer to variable userDUI
            Console.WriteLine("Have you ever had a DUI?");
            string userDUI = (Console.ReadLine());

            //print question to screen, declare variable and assign answer converted to integer to variable userTickets
            Console.WriteLine("How many speeding tickets do you have?");
            int userTickets = Convert.ToInt32(Console.ReadLine());

            //declared boolean variable evaluated to true if all three statements are true
            bool isUserQualified = (userAge > 15 && userDUI == "no" && userTickets < 3);

            //print to screen if qualified, print to screen to result of the variable isUserQualified
            Console.WriteLine("Do you qualify?");
            Console.WriteLine(isUserQualified);

            Console.ReadLine();


        }
    }
}

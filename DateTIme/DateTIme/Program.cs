using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTIme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the current date and time to the console
            Console.WriteLine("Hello! The current time and date is: " + DateTime.Now);
            //saves the current date and time to the DateTime variable now
            DateTime now = DateTime.Now;
            //Asks the user for a number
            Console.WriteLine("Please enter a number between 1 and 10.");
            //assigns the user input converted to int to the int varaible userHour
            int userHour = Convert.ToInt32(Console.ReadLine());
            //declares the DateTime variable futureHour, executes the method AddHours() to the variablle now,
            //and assigns that to futureHour
            DateTime futureHour = now.AddHours(userHour);
            //Prints to the console the exact time it will be in X hours,
            //X being the number the user entered
            Console.WriteLine("In {0} hours it will be {1}", userHour, futureHour); 


            Console.ReadLine();
        }
    }
}

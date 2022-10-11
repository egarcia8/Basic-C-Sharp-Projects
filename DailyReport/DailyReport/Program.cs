using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy"); //first two lines printed to screen 
            Console.WriteLine("Student Daily Report"); 

            Console.WriteLine("What is your name?"); // question printed to screen
            string yourName = Console.ReadLine(); //declared a variable of data type string named yourName and assigned to what was input by user

            Console.WriteLine("What course are you on?"); // question printed to screen
            string currentCourse = Console.ReadLine(); //declared variable of data type string named currentCourse and assigned to what was input by user

            Console.WriteLine("What page number?"); // question printed to screen
            int pageNumber = Convert.ToInt32(Console.ReadLine()); //declared variable of data type integer named pageNumber, cast user input to integer

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"."); //question printed to screen
            bool needHelp = Convert.ToBoolean(Console.ReadLine()); //declared variable needHelp of data type bool, cast user input to boolean

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); // question printed to screen
            string postiveExperiences = Console.ReadLine(); //declared variable postiveExperiences of data type string and assigned to what was input by user

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific."); // question printed to screen
            string feedback = Console.ReadLine(); //declared variable feedback of data type string, assigned to what was input by user

            Console.WriteLine("How many hours did you study today?"); // question printed to screen
            byte hoursStudied = Convert.ToByte(Console.ReadLine()); //declared variable hourStudied of data type byte, cast user input to byte and assigned it to the variable

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!"); 

            Console.ReadLine();
        }
    }
}

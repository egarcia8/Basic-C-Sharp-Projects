using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            try //try/catch block to print to console if user does not enter a day of the week
            {
                //Prompted the user to enter the current day of the week

                Console.WriteLine("What day is today?");
                var currentDay = Console.ReadLine();
                currentDay = currentDay.ToLower();

                //Assigned the value to a variable of that enum data type just created.
                Days day = (Days)Enum.Parse(typeof(Days), currentDay);
                Console.WriteLine("Today is " + day);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        //Created an enum for the days of the week
        public enum Days
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample

{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to input two numbers, one at a time.
            //Let them know they need not enter anything for the second number.

            Console.WriteLine("Please enter the size of your first class."); 
            int class1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If you have a second class enter it now.");
            string checkClass = Console.ReadLine();

            //condition statement to call method passing one or two numbers entered
            if (String.IsNullOrEmpty(checkClass)) //if did not enter a second number call method to
                                                  //pass argument and use default 
            {
                Calculations students = new Calculations();
                Console.WriteLine("Your student total is: " + Calculations.Total(class1));
            }
            else //if entered second number pass both arguements to call method
            {
                int class2 = Convert.ToInt32(checkClass); //convert string to int to pass second argument
                Console.WriteLine("Your student total is: " + Calculations.Total(class1, class2));
            }

            Console.ReadLine();
        }
    }
}

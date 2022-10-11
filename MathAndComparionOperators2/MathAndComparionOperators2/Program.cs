using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparionOperators2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some math! \nEnter a number.");

            //Takes an input from the user, multiplies it by 50, then prints the result to the console.
            int productInput = Convert.ToInt32(Console.ReadLine());
            int product = productInput * 50;
            Console.WriteLine("Your number times 50 = " + product);

            //Takes an input from the user, adds 25 to it, then prints the result to the console.
            Console.WriteLine("Enter a number.");
            int sumInput = Convert.ToInt32(Console.ReadLine());
            int sum = sumInput + 25;
            Console.WriteLine("Your number plus 25 = " + sum);

            //Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("Enter a number.");
            double quotientInput = Convert.ToDouble(Console.ReadLine());
            double quotient = quotientInput / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + quotient);

            //Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
            Console.WriteLine("Enter a number.");
            int numInput = Convert.ToInt32(Console.ReadLine());
            bool compareNumber = numInput > 50;
            Console.WriteLine("Your number is greater than 50. --" + compareNumber);

            //Takes an input from the user, divides it by 7, then prints the remainder to the console
            Console.WriteLine("Enter a number.");
            int remainderInput = Convert.ToInt32(Console.ReadLine());
            int remainder = remainderInput % 7;
            Console.WriteLine("Your number divided by 7 has a remainder of " + remainder + ".");

            Console.ReadLine();
        }
    }
}

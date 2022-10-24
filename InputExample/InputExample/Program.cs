using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for a number
            Console.WriteLine("Please enter a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            //Logs that number to a text file, "using" helps dispose of system resources
            using (StreamWriter file = new StreamWriter(@"C:\Users\egarc\Logs\examplelog.txt", true))
            {
                file.WriteLine(userNumber);
            }

            //Prints the text file back to the user
            using (StreamReader reader = new StreamReader(@"C:\Users\egarc\Logs\examplelog.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine("Example Log: " + line);
                }
            }
            

            Console.ReadLine();
        }
    }
}

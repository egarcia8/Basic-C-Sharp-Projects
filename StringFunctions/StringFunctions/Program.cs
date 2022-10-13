using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Evelina";
            string birthdate = "May 31";
            string favColor = "purple";
            favColor = favColor.ToUpper();

            Console.WriteLine("My name is " + myName + ". My birthday is on " + birthdate + ", and my favorite color is " + favColor + ".");


            StringBuilder sb = new StringBuilder();
            sb.Append("This is my first paragraph using Stringbuilder.");
            sb.Append("\nI am building the paragraph one sentence at a time.");
            sb.Append("\nI think I am doing this correctly.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

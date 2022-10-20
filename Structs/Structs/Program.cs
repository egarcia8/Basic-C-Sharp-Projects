using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number price = new Number() { Amount = 2.50m };
            Console.WriteLine("The price is " + price.Amount);
            Console.ReadLine();
        }
        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}

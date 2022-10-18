using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Operations
    {
        public static int Add(int userInput)
        {
            return userInput + 10;
        }

        public static int Multiply(int userInput)
        {
            return userInput * 10;
        }

        public static int Subtract(int userInput)
        {
            return userInput - 10; 
        }
    }
}

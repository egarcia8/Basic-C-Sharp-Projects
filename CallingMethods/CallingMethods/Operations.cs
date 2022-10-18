using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Operations //created a seperate class to hold methods
    {
        public static int Add(int userInput) //created method with access modifier public(other classes can access it)
        {                                      //static so as to instantiate it to call it, and it returns an integer value 
            return userInput + 10;          //the method requires a parameter of an integer provided by the user
            //the method adds 10 to the user input and returns the value
        }

        public static int Multiply(int userInput)
        {
            return userInput * 10;
            //the method multiplies 10 to the user input and returns the value
        }

        public static int Subtract(int userInput)
        {
            return userInput - 10;
            //the method subtracts 10 from the user input and returns the value
        }
    }
}

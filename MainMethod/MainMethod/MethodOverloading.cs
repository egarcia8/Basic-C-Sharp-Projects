using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    //Created a class. In that class, created a method that 
    //takes in an integer, created a math operation for this integer
    public class MethodOverloading
    {
        public static int Multiply(int number)
        {
            return number * 8;
        }


        //Added a second method to the class with the same name that takes in a decimal,
        //created a different math operation for it, then returns the answer as an integer.
        public static int Multiply(float number)
        {
            int product = (int)(number * 10);
            return product;
        }


        //Added a third method to the class, with the same name, that takes in a string,
        //converts it to an integer, does a different math operation to it,
        //then returns the answer as an integer.

        public static int Multiply(string number)
        {
            int product = Convert.ToInt32(number) * 8;
            return product;
        }
    }
}

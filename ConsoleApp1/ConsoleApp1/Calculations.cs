using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample
{
    public class Calculations //created a public class called Calculations
    {
        //created a method that takes two integers as parameters, one of them optional.
        //The method adds two parameters and returns an integer result.

        public static int Total(int num1, int num2 = 5)
        {
            return num1 + num2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiate the class and call the one method, passing in an integer.
            //Display the result to the screen.
            MethodOverloading example = new MethodOverloading();
            int answerOne = MethodOverloading.Multiply(6);
            Console.WriteLine(answerOne);

            //instantiate the class and call the second method,
            //passing in a decimal. Display the result to the screen.
            MethodOverloading example2 = new MethodOverloading();
            int answerTwo = MethodOverloading.Multiply(8.2f);
            Console.WriteLine(answerTwo);

            //instantiate the class and call the third method, passing in a
            //string that equates to an integer. Display the result to the screen.
            MethodOverloading example3 = new MethodOverloading();
            int answerThree = MethodOverloading.Multiply("32");
            Console.WriteLine(answerThree);

            Console.ReadLine();
        }
        
    }
}

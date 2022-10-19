using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    public class Student //created public class named Student
    {
        //A void method that takes two integers as parameters.
        //Method does a math operation on the first integer and
        //displays the second integer to the screen.
        public static void testAvg(int testGrade, float weight)
        {
            float testScores = testGrade * weight;
            Console.WriteLine("Your weighted test average is " + testScores);
            Console.WriteLine("Test scores are worth " + weight + " of your class average.");

        }
    }
}

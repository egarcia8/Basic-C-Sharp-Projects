using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentA = new Student(); //instantiate the class

            Student.testAvg(95, .70f); //Call the method in the class, passing in two numbers

            Student.testAvg(testGrade: 85, weight: .70f); //Call the method in the class,
                                                          //specifying the parameters by name

            Console.ReadLine();
        }
    }
}

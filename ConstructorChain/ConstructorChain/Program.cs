using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a const variable
            const int basePay = 15;

            Employee employee = new Employee("John Doe");
            //Create a variable using the keyword “var”
            var weeklyPay = basePay * employee.HoursWorked;

            Console.WriteLine("{0}'s weekly pay was ${1}.", employee.FirstLastName, weeklyPay);
            Console.ReadLine();

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiated and initialized an Employee object with a first name of “Sample” and a last name of “Student”.
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            //Called the superclass method SayName() on the Employee object.
            employee.SayName();
            Console.ReadLine();
        }
    }
}

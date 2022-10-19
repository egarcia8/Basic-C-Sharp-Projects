using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiated an Employee object with firstName “Sample” and lastName “Student”.
            //Call the SayName() method on the object.
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();

            //Used polymorphism to create an object of type IQuittable and called the Quit() method on it.
            //**an object can be of an interface type if it implements that specific interface
            IQuittable exEmployee = new Employee() { firstName = "Previous", lastName = "Employee" };
            exEmployee.Quit();

            Console.ReadLine();
        }
    }
}

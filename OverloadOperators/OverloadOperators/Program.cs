using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    class Program
    {
        static void Main(string[] args)
        {   
            //instantiated two employee objects to compare Ids using the overloaded operator
            Employee e1 = new Employee() { Id = 1, firstName = "Sam", lastName = "Jones" };
            Employee e2 = new Employee() { Id = 2, firstName = "Thomas", lastName = "Gomez" };
            if (e1 == e2)
            {
                Console.WriteLine("Ids are the same.");
            }
            else
            {
                Console.WriteLine("Ids are not the same.");
            }
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //created a list of at least 10 employees.
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, firstName = "Joe", lastName = "Kimble" },
                new Employee { Id = 2, firstName = "Mary", lastName = "Lamb" },
                new Employee { Id = 3, firstName = "Jane", lastName = "Eyre" },
                new Employee { Id = 4, firstName = "Joe", lastName = "Black" },
                new Employee { Id = 5, firstName = "Elizabeth", lastName = "Bennet" },
                new Employee { Id = 6, firstName = "William", lastName = "Darcy" },
                new Employee { Id = 7, firstName = "Atticus", lastName = "Finch" },
                new Employee { Id = 8, firstName = "Scout", lastName = "Finch" },
                new Employee { Id = 9, firstName = "Rachel", lastName = "Green" },
                new Employee { Id = 10, firstName = "Ross", lastName = "Gellar" }
            };

            //Using a foreach loop, created a new list of all employees with the first name “Joe”
            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in employees)
            {

                if (employee.firstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }
            foreach (Employee joe in joeList)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName);
            }

            //created a new list of all employees with the first name “Joe” using a lambda expression **Where() produces a list
            foreach (Employee employee in employees.Where(e => e.firstName == "Joe").ToList()) 
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName);
            }
            //made a list of of all employees with an Id number greater than 5 using a lambda expression
            foreach (Employee employee in employees.Where(e => e.Id > 5))
            {
                Console.WriteLine("Id #" + employee.Id + " " + employee.firstName + " " + employee.lastName);
            }


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Employee
    {
        //Chain two constructors together
        public Employee (string name) : this (name, 40)
        {

        }

        public Employee(string name, int hoursWorked)
        {
            FirstLastName = name;
            HoursWorked = hoursWorked;

        }

        public string FirstLastName;
        public int HoursWorked;
    }

}

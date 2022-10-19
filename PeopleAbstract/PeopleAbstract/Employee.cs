using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAbstract
{
    class Employee : Person //created class Employee that inherits from the Person class
    {
        //Implemented the SayName() method 
        public override void SayName()
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Name: " + fullName);
        }
    }
}

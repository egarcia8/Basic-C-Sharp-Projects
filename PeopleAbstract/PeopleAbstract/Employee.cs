using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAbstract
{
    class Employee : Person, IQuittable //created class Employee that inherits from the Person class and the IQuittable interface
    {
        //Implemented the SayName() method 
        public override void SayName()
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Name: " + fullName);
        }
        //implemented Quit() method inherited from IQuittable
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has put in their two weeks notice.");
        }
    }
}

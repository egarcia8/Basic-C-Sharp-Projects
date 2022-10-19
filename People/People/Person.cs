using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Person //created a public class named Person
    {   //give it two properties, each of data type string. One called FirstName, the other LastName.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //void method called SayName() that takes no parameters and writes the
        //person's full name to the console in the format of: “Name: [full name]”
        public void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + fullName);
        }
    }
}

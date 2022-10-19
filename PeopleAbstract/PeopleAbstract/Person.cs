using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAbstract
{
    public abstract class Person //Created an abstract class called Person with two properties:
                                 //string firstName and string lastName.

    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Gave it the method SayName()
        public virtual void SayName()
        {
            
        }
    }
}

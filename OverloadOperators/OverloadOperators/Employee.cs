using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    public class Employee //created an Employee class with Id, FirstName and LastName properties. 

    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }


        //overloaded the “==” operator so it checks if two Employee objects are equal by comparing
        //their Id property
        public static bool operator== (Employee e1, Employee e2)
        {
            if (e2.Id == e1.Id)
                return true;
            else
                return false;

        }
        public static bool operator!= (Employee e1, Employee e2)
        {
            if (e2.Id != e1.Id)
                return true;
            else
                return false;

        }
    }
}

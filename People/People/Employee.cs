using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Employee : Person // Created another class called Employee and it inherits from the Person class.
                            // Employee class has a property called Id and it is of data type int.
    {
        public int Id { get; set; }
    }
}

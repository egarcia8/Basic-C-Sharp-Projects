using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfo
{
    public static class Teacher //create public class named Teacher
    {
        //created a void method that outputs an integer.
        //Method divides the data passed to it by 2
        public static void avgPerClass(int num)
        {
            int studentsPerClass = num / 2;
            Console.WriteLine(studentsPerClass);
        }
         //created method with output parameter
        public static void booksPerClass(out int books)
        {
            books = 150 * 8;
        }

        //overloaded a method
        public static void booksPerClass(int students, out int books)
        {
            books = students * 8;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher(); //instantiate the class

            //user enters number
            Console.WriteLine("Please enter total number of students.");
            int totalStudents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Average students per class: "); 
            //method called on number
            Teacher.avgPerClass(totalStudents);
            
            int books = 0;
            Teacher.booksPerClass(out books);
            Console.WriteLine("You need a total of " + books + " books.");
            Teacher.booksPerClass(44, out books);
            Console.WriteLine("You need a total of " + books + " books.");

            Console.ReadLine();
        }
    }
}

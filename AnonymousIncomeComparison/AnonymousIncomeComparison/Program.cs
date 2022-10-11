using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program starts by printing "Anonymous Income Comparison Program” to the screen.
            Console.WriteLine("Anonymous Income Comparison");

            //print “Person 1” to the screen
            Console.WriteLine("Person 1 Information");
            //get hourly rate from user input
            Console.WriteLine("What is your hourly rate?");
            //declare a double variable named hourlyRate and assign the user input that was converted to double to it
            double hourlyRate = Convert.ToDouble(Console.ReadLine());
            //get hours worked per week from user input
            Console.WriteLine("How many hours do you work per week?");
            //declare a int variable named hoursWorked and assign the user input converted to int to it
            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            //print “Person 2” to the screen
            Console.WriteLine("Person 2 Information");
            //get hourly rate from user input
            Console.WriteLine("What is your hourly rate?");
            //declare a double variable named hourlyRate2 and assign the user input that was converted to double to it
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            //get hours worked per week from user input
            Console.WriteLine("How many hours do you work per week?");
            //declare a int variable named hoursWorked2 and assign the user input converted to int to it
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());

            //print “Annual salary of Person 1:” and display the exact salary below it.
            Console.WriteLine("Annual Salary of Person 1:");
            double salaryPerson1 = (hourlyRate * hoursWorked) * 52; //declare variable and assign the product of hourlyRate and hoursWorked times weeks in a year
            Console.WriteLine(salaryPerson1);

            //print “Annual salary of Person 2:” and display the exact salary below it.
            Console.WriteLine("Annual Salary of Person 2:");
            double salaryPerson2 = (hourlyRate2 * hoursWorked2) * 52; //declare variable and assign the product of hourlyRate and hoursWorked times weeks in a year
            Console.WriteLine(salaryPerson2);

            //print to the screen “Does Person 1 make more money than Person 2?” and write the true or false
            //value of this statement below it.
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compareSalary = salaryPerson1 > salaryPerson2; //declare variable of boolean data type to compare both salaries
            Console.WriteLine(compareSalary); //print to screen whether the above statement is true or false

            Console.ReadLine();

        }
    }
}

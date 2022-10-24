using System;
using System.Collections.Generic;


namespace ExceptionHandlingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try // beginning of try/catch block to handle exceptions
            {
                //created a new instance of list, poulated the values with integers
                List<int> numbers = new List<int> { 24, 15, 18, 36, 42 };
                //asked the user for a number
                Console.WriteLine("Please enter a number to divide each number in my list by.");
                //declared an integer variable called userDivisor and assigned the user input converted to an integer to it
                int userDivisor = Convert.ToInt32(Console.ReadLine());
                //loop that takes each integer in the list, divides in by the number the user entered, 
                //and displays the result to the screen
                foreach (int number in numbers)
                {
                    int quotient = number / userDivisor;
                    Console.WriteLine(number + " divided by " + userDivisor + " equals " + quotient);
                }
            }
            catch (DivideByZeroException ex) //will display an error message when user enters zero
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex) //will display an error message if the wrong format such as string is entered
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Your program will continue executing.");
                Console.ReadLine();
            }
            
            
            
            try
            {
                Console.WriteLine("Please enter your age.");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new AgeException();
                }
                DateTime currentYear = DateTime.Now;

                int yearBorn = currentYear.Year - age;
                Console.WriteLine("You were born in {0}.", yearBorn);
                Console.ReadLine();
            }
            catch (AgeException)
            {
                Console.WriteLine("You must enter a number greater than zero.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("That is not your age.");
                Console.ReadLine();
                return;
            }
            finally
            {
                Console.WriteLine("Please enter your age.");
                int age = Convert.ToInt32(Console.ReadLine());
                DateTime currentYear = DateTime.Now;
                int yearBorn = currentYear.Year - age;
                Console.WriteLine("You were born in {0}.", yearBorn);
                Console.ReadLine();
            }





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleAppLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment Part One
            //A one-dimensional array of strings
            string[] names = { "Evelina", "Dennis", "Nicolas", "Sebastian", "Elijah", "Charlie" };
            //user inputs name
            Console.WriteLine("Please enter a singular present verb (i.e. claps, jokes, giggles, etc).");
            //declare string variable userName and assigned user input to it
            string userVerb = Console.ReadLine();

            //create a for loop that iterates through each string in the array. 
            for (int i = 0; i < names.Length; i++)
            {
                string newString = names[i] + " " + userVerb; //newString is created that concatenates names element and user input
                names[i] = newString; //newString replaces the element at i index
            }

            //create a foreach loop that goes through each element and prints each string to screen one at a time
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Assignment Part Two
            //an infinite loop
            //for (int i = 10; i < 25; i--)
            //{
            //    Console.WriteLine("Good morning!");
            //}

            //fixed infinite loop - value of i was initially set at 10, but since it was decremnting it would never get to be more than 25
            //meaning this condition would always be true. Changing the condition allows it to get to a false evaluation stopping the loop.
            for (int i = 10; i > 3; i--)
            {
                Console.WriteLine("Good morning!");
            }

            //Assignment Part Three
            //a for loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("This loop will iterate 2 times.");
            }

            // a for loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            for (int j = 1; j <= 3; j++)
            {
                if (j == 1)
                {
                    Console.WriteLine("You have " + j + " sticker!");
                }
                else
                {
                    Console.WriteLine("You have " + j + " stickers!");
                }
            }

            //Assignment Part Four
            //A list of strings where each item in the list is unique
            List<string> fruits = new List<string> { "apples", "mangos", "grapes", "strawberries", "peaches", "kiwis" };
            //declaring a boolean variable isCorrect to false to utilize to break the loop
            bool isCorrect = false;
            while (!isCorrect) //while isCorrect is false the while loop will continue
            {
                //Ask the user to input text to search for in the list
                Console.WriteLine("\n\tGuess one of my favorite fruits.");
                string userGuess = Console.ReadLine();
                //A loop that iterates through the list and then prints the index of the
                //list item that contains matching text on the screen.
                foreach (string fruit in fruits)
                {
                    if (userGuess == fruit)
                    {
                        Console.WriteLine("You guessed correctly.\n" + userGuess + " was element " + fruits.IndexOf(fruit) + " on my list.");
                        isCorrect = true;
                        break;
                    }
                }
            }



            //Assignment Part Five
            //A list of strings that has at least two identical strings in the list
            List<string> months = new List<string> { "january", "june", "may", "september", "june", "february", "march" };
            //Ask the user to select text to search for in the list
            Console.WriteLine("\n\tDo you share a birth month with someone in my family?\nWhat is your birth month?");
            string userMonth = Console.ReadLine();
            userMonth = userMonth.ToLower();
            //declaring a boolean variable isFound to false to utilize to break the loop
            bool isFound = false;
            //Create a loop that iterates through the list and then displays the indices of the items matching the 
            //user - selected text.Ensure to remove any break statements that may prevent your code from returning multiple matches.
            for (int i = 0; i < months.Count; i++)
            {
                if (userMonth == months[i])
                {
                    Console.WriteLine("You share a birth month with us. " + userMonth + " is element " + i + " on my list.");
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("You do not share a birth month with us.");
            }

            //Assignment Part Six
            //a instance of list of strings that has at least two identical strings in the list
            List<string> letters = new List<string> { "A", "S", "E", "A", "D", "N" };
            //{ "A", "S", "E", "A", "D", "N" };
            //created a loop that evaluates each item in the list, and displays a message showing
            //the string and whether or not it has already appeared in the list.
            for (int i = 0; i < letters.Count; i++) //using two for loops to compare the values of the same list to each other
            {
                bool isDuplicate = false; //declaring a boolean variable isDuplicate to false to utilize to break the loop
                for (int j = 0; j < i; j++)
                {
                    if (letters[i] == letters[j])
                    {
                        Console.WriteLine(letters[j] + " is a duplicate.");
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(letters[i] + " is unique.");

                }
            }



            Console.ReadLine();
        }
    }
}

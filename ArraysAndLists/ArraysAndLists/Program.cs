using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialzing stringArray by creating a new instance of that array and adding strings to array
            string[] stringArray = { "apples", "grapes", "strawberries", "oranges", "bananas", "mangos" };

            //asking user for input
            Console.WriteLine("Select an index to display the string.");
            int arrayIndex = Convert.ToInt32(Console.ReadLine()); //declaring int variable arrayIndex and assigning user input converted to integer
            bool isCorrect = arrayIndex < 6; //declaing bool variable isCorrect and sets it to true if arrayIndex is less than 6

            do //initiates do while loop
            {
                switch(arrayIndex) //uses the expression number to begin switch case
                {
                    case 0: //if arrayIndex is 0 then the following code executes
                        Console.WriteLine("You chose " + stringArray[arrayIndex]);
                        isCorrect = true;
                        break;
                    case 1: //if arrayIndex is 1 then the following code executes
                        Console.WriteLine("You chose " + stringArray[arrayIndex]);
                        isCorrect = true;
                        break;
                    case 2: //if arrayIndex is 2 then the following code executes
                        Console.WriteLine("You chose " + stringArray[arrayIndex]);
                        isCorrect = true;
                        break;
                    case 3: //if arrayIndex is 3 then the following code executes
                        Console.WriteLine("You chose " + stringArray[arrayIndex]);
                        isCorrect = true;
                        break;
                    case 4: //if arrayIndex is 4 then the following code executes
                        Console.WriteLine("You chose " + stringArray[arrayIndex]);
                        isCorrect = true;
                        break;
                    case 5: //if arrayIndex is 5 then the following code executes
                        Console.WriteLine("You chose " + stringArray[arrayIndex]);
                        isCorrect = true;
                        break;
                    default: //if none of the other cases are met this runs the following block of code
                        Console.WriteLine("That index doesn't exist. Please choose an index less than 6.");
                        arrayIndex = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isCorrect); //do while loop will run while isCorrect is false

            //initializing integer array by creating a new instance of that array and adding the values of each index
            int[] intArray = { 5000, 850, 1986, 4523, 1202, 962 }; 
            Console.WriteLine("Select an index to display the integer."); 
            int intIndex = Convert.ToInt32(Console.ReadLine()); //declaring int variable arrayArray and assigning user input converted to integer
            bool pickedCorrect = intIndex < 6; //declaing bool variable pickedCorrect and sets it to true if intIndex is less than

            do //same do while loop as above
            {
                switch (intIndex)
                {
                    case 0:
                        Console.WriteLine("You chose " + intArray[intIndex]);
                        pickedCorrect = true;
                        break;
                    case 1:
                        Console.WriteLine("You chose " + intArray[intIndex]);
                        pickedCorrect = true;
                        break;
                    case 2:
                        Console.WriteLine("You chose " + intArray[intIndex]);
                        pickedCorrect = true;
                        break; 
                    case 3:
                        Console.WriteLine("You chose " + intArray[intIndex]);
                        pickedCorrect = true;
                        break; 
                    case 4:
                        Console.WriteLine("You chose " + intArray[intIndex]);
                        pickedCorrect = true;
                        break; 
                    case 5:
                        Console.WriteLine("You chose " + intArray[intIndex]);
                        pickedCorrect = true;
                        break; 
                    default:
                        Console.WriteLine("That index doesn't exist. Please choose an index less than 6.");
                        intIndex = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!pickedCorrect);


            //initialized the  string list by creating a new instance of List<string> and added values to each index
            List<string> stringNames = new List<string>() { "Evelina", "Dennis", "Nicolas", "Sebastian", "Elijah", "Charlie" };
            Console.WriteLine("Choose a number less than 6 to pick a name.");
            int nameIndex = Convert.ToInt32(Console.ReadLine()); //declared in variable nameIndex and assigned it user input converted to integer
            
            //if else condition to display a message that the index the user chose does not exist
            if(nameIndex < 6) // if nameIndex is less than 6 the screen will display the content of that index
            {
                Console.WriteLine("You chose " + stringNames[nameIndex]);
            }
            else // if nameIndex is not less than 6 the following message will display
            {
                Console.WriteLine("That index does not exist. That number is not less than 6. You lose.");
            } 

            Console.ReadLine();
        }
    }
}

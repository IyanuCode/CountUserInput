using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class UserInputApp
    {

        public static void UserInputMethod() {
            Console.WriteLine("Welcome to the User Input App!");
            Console.WriteLine("Please enter a string to proceed:");
            string? userInput = Console.ReadLine();
    
            string newVariable = string.Empty;
            // userInput = userInput.Replace(" ", string.Empty);
            // Console.WriteLine("User input after removing spaces: " + userInput);

            // Check if the user input is empty, null, whitespace, or less than 1 character
            if (string.IsNullOrEmpty(userInput) || string.IsNullOrWhiteSpace(userInput) || userInput.Length < 1)
            {
                Console.WriteLine("Enter a valid string with at least one character.");
            }
            else
            {
                //trim the input, remove spaces, and convert to lowercase
                string trimmedInput = userInput.Replace(" ", string.Empty).Trim().ToLower();
                //Console.WriteLine("User input after processing and conveting to lower case: " + trimmedInput);

                foreach (var item in trimmedInput)
                {
                    // if index of the item is equal to the last index of the item, it means it is a unique character
                    if (trimmedInput.IndexOf(item) == trimmedInput.LastIndexOf(item))
                    {
                        newVariable += item.ToString();
                        //Console.WriteLine("User input contains duplicate characters.");
                    }
                    // if index of the item is not equal to the last index of the item, it means it is a duplicate character
                    else if (trimmedInput.IndexOf(item) != trimmedInput.LastIndexOf(item))
                    {
                        // check if the newVariable does not contain the item, then add it to the newVariable
                        if (!newVariable.Contains(item))
                        {
                            newVariable += item.ToString();
                            //Console.WriteLine("User input does not contain duplicate characters.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("No Condition met for user input.");
                    }


                }
                Console.WriteLine("The number of word you entered is: " + newVariable.Length + "\n");
              
            }
           
           
        
            

            
        }
         
    }
}
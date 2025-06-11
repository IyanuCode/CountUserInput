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
            string userInput = Console.ReadLine();
            
            //userInput is letter is letter or space and not empty
            if (userInput.All(eachChar => char.IsLetter(eachChar) || eachChar == ' ') && !string.IsNullOrEmpty(userInput)  )
            {
                //removing leading and trailing spaces and replacing multiple spaces
                string userInputTrimmed = userInput.Trim().Replace(" ", "");

                //removing duplicate characters using Distinct()
                string checkInput = new string(userInputTrimmed.Distinct().ToArray());
                Console.WriteLine($"\nThe trimmed output is: \"{checkInput}\"");
                Console.WriteLine($"The total number of string you entered is: {checkInput.Length}");
            }
            else
            {
                Console.WriteLine("Input Must be Text and Should Not Be Number");
            }
              
           
           
        
            

            
        }
         
    }
}
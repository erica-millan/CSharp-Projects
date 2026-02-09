using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consle_app_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool comparison using while statement asking for the magic word
            //getting input from user
            Console.WriteLine("Enter the magic word");
            //storing it in the variable magicWord
            string magicWord = Console.ReadLine();
            //creating as bool magic word and comparing it to the string unicorn which is the magic word
            bool magicPass = magicWord == "unicorn";
            //while not magicPass (which is the text unicorn)
            while (!magicPass)
            {
                //run this code. issue is that if you put unicorn first it will never hit this part.
                switch (magicWord)
                {
                    case "unicorn":
                        Console.WriteLine("You have entered the magic word and may enter the royal vehicle");
                        magicPass = true;
                        break;
                    default:
                        Console.WriteLine("That is not the magic word. Try  again.");
                        magicWord = Console.ReadLine();
                        break;

                }
                //added this part if user puts unicorn on the first try so progmram responds
                if(magicPass)
                {
                    Console.WriteLine("You have entered the magic word and may enter the royal vehicle");
                }

            }

            //bool comparison using do while statement fortune
            //do while loop will run code once at least this works for when the 
            //user enters fortune if will display fortune at least once
            //displaying message to user
            Console.WriteLine("Welcome to the fortune teller, where your choice reveals your destiny");
            Console.WriteLine("For your fortune, enter fortune, if you want to exit type \"exit\" for an exit message");
            //capturing user input
            string userInput = Console.ReadLine();
            //creating a bool to compare user input to fortune and exit
            bool fortune = userInput == "fortune";
            //do while loop 
            do
            {
                //these are the cases of user inputs.
                //will either be fortune, exit, or default which is invalid input
                //this ill keep running until the user enters either fortune or exit, since 
                //i set fortune to true in those cases and it will escape the while loop
                switch (userInput)
                {
                    case "fortune":
                        Console.WriteLine("You will have an amazing day!");
                        fortune = true;
                        break;
                    case "exit":
                        Console.WriteLine("Thank you for visiting the fortune teller, have a nice day!");
                        fortune = true;
                        break;
                    default:
                        Console.WriteLine("That is not a valid input, please try again.");
                        userInput = Console.ReadLine();
                        break;
                }
            }
            while (!fortune);
        }
    }
}

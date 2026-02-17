using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiating MathOperations class
            MathOperations op = new MathOperations();

            Console.WriteLine("Input your first number:");
            int firstInput = Convert.ToInt32(Console.ReadLine());

            //if user presses enter instead of a number it will return an empty string 
            //have to read input as a string and check it ifs empty, only converting if it's not empty
            Console.WriteLine("Input your second number: (this part is optional, press enter to bypass)");
            string secondInputCheck = Console.ReadLine();

            //checking if user entered a value 
            int secondInput;
            if (string.IsNullOrWhiteSpace(secondInputCheck))
            {
                //user didn't add input setting secondInput = 1;
                secondInput = 1;
            } 
            else
            {
                // user added input need to convert it to int
                secondInput = Convert.ToInt32(secondInputCheck);
            }

            //setting result = to the op object.add numbers which is the method addd numbers in the math operations class with the 2 user inputs in
            int result = op.addNumbers(firstInput, secondInput);
            //writing result to console
            Console.WriteLine("Your first value times second value is: " + result);
        }
    }
}

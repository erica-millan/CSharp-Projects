using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Calling_methods_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //get operand from user
            Console.WriteLine("What number do you want to do math on?");
            string userInput = Console.ReadLine();

            //convert the string to decimal
            decimal operand = Convert.ToDecimal(userInput);

            //calling each method storing returned value in corresponding variables
            decimal sum = Math_Operations.AddTen(operand);
            decimal product = Math_Operations.MultiplyByTen(operand);
            decimal quotient = Math_Operations.DivideByTwo(operand);

            // displaying the returned integer to the console

            Console.WriteLine("Users selected number plus 10 is: " + sum );
            Console.WriteLine("Users selected number times 10 is: " + product );
            Console.WriteLine("Users selected number divided by 2 is: " + quotient );
        }
    }
}

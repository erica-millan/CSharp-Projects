using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //instantiating the class
            Math_Operations ops = new Math_Operations();

            //calling int method
            int intOperand = 10;
            //calling methoding passing in an int
            int intResult = ops.mathOp(intOperand);
            //display result to the console
            Console.WriteLine("Result of the int method: " + intResult);

            //calling decimal method
            decimal decOperand = 20.5m;
            //calling methoding passing in a dec
            int decResult = ops.mathOp(decOperand);
            //display result to the console
            Console.WriteLine("Result of the decimal method: " + decResult);

            string strOperand = "10";
            //calling methoding passing in a string
            int stringResult = ops.mathOp(strOperand);
            //display result to the console
            Console.WriteLine("Result of the string method: " + stringResult);

           /*
            * keeping incorrect code to compare later
            int intOperand = 10;
            int intResult = Math_Operations.mathOp(intOperand);
            Console.WriteLine("Result of the int method: " + intResult);

            decimal decOperand = 20.5m;
            int decResult = Math_Operations.mathOp(decOperand);
            Console.WriteLine("Result of the decimal method: " + decResult);

            string strOperand = "10";
            int stringResult = Math_Operations.mathOp(strOperand);
            Console.WriteLine("Result of the string method: " + stringResult);
           */
        }
    }
}

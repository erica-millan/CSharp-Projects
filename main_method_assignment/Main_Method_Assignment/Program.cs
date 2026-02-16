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
            //callingi nt method
            int intOperand = 10;
            //instantaiting the class, calling methoding passing in an int
            int intResult = Math_Operations.mathOp(intOperand);
            //display result to the console
            Console.WriteLine("Result of the int method: " + intResult);

            //calling decimal method
            decimal decOperand = 20.5m;
            //instantiating the class, calling methoding passing in a dec
            int decResult = Math_Operations.mathOp(decOperand);
            //display result to the console
            Console.WriteLine("Result of the decimal method: " + decResult);

            string strOperand = "10";
            //instantaiting the class, calling methoding passing in a string
            int stringResult = Math_Operations.mathOp(strOperand);
            //display result to the console
            Console.WriteLine("Result of the string method: " + stringResult);

        }
    }
}

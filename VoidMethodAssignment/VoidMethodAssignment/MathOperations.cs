using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    public class MathOperations
    {
        //void method that takes two integers as paramaters
        //void method performs an action and doesn't return a value
        public void addNumbers(int op1, int input)
        {
            //method doing a math operatino on the first int
            int result = op1 + 1;

            //displaying the second int
            Console.WriteLine("The second input is: " + input);
        
        }
    }
}

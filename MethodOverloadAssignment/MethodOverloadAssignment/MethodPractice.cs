using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadAssignment
{
    public class MethodPractice
    {
        //void method that takes an int divides by 2 and outputs to the console.
        public void divideByTwo(int operand)
        {
            int result = operand / 2;
            Console.WriteLine(result);
        }

        //method with output parameters
        //Lets a method return more than one value, they can return extra values through the 
        //parameters themselves
        public void multiplyByItself(int num, out int multiplied)
            {
            //insdie method you have to assign value to the out variable
            multiplied = num * num;

            }

        //overloading a method they are both names the name with one having a parameter
        public void doWork()

        {
            Console.WriteLine("Doing lots of work right now.");
        }
        //overloading method with string parameter
        public void doWork(string amount)

        {
            Console.WriteLine("Doing " + amount + " of work right now.");
        }



    }
}

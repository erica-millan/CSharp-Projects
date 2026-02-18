using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instantiate the class
            MethodPractice op = new MethodPractice();

            Console.WriteLine("Please enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            op.divideByTwo(userInput);

            //call method with output parameter
            //declare variable result and pass into method using out
            //method fills it using a value and it can be used afterward
            int result;
            op.multiplyByItself(10, out result);
            Console.WriteLine(result);

            //call overloaded methods
            op.doWork();
            //adding a string paramter
            op.doWork("little");

            //calling static class sound, sound methods
            Sound.Clink();
            Sound.Wham();
            Sound.Zap();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //list of integers to divide by number user selects
                List<int> intList = new List<int>() {100, 200, 300, 400, 500, 600, 700 };
                Console.WriteLine("Enter a number to divide a list of integers by.");
                int userSelection = Convert.ToInt32(Console.ReadLine());
                //for loop that iterates through each integer in the list
                for(int i = 0; i<intList.Count; i++)
                {
                    Console.WriteLine(intList[i] / userSelection);
                }

            }
            //catching format exception for strings inputted
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catching 0 exception when user inputs a 0
            catch(DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("The program has emerged from the try/catch block and continued execution.");

        }
    }
}

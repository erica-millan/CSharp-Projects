using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week");
            string userInput = Console.ReadLine();

            //enum has an underlying data type of integer so you can always cast
            //and enum to it's underlying integeter datatype
            try
            {
                // Convert the input (string) into the enum type
                //Assign the value to a variable of that enum
                //data type just created. 
                //Days of the week is the type, (the enum.) creating a variable named
                //day that holds one of the enum values.
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);
            }
            catch
            {
                //Invalid user input
                Console.WriteLine("Please enter an actual day of the week.");
            }

        }
        //creating an enum for days of the week
        //Monday - friday the underlying ints will be 0-6
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

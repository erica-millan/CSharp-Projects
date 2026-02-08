using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_quote_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //App to calculate a shipping quote based on package volume and weight. 
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //prompt user for weight first making sure it's a number and then checking if it's over 50 lbs
            Console.WriteLine("What is the weight of your package?");
            decimal packageWeight;
            while (!decimal.TryParse(Console.ReadLine(), out packageWeight))
            {
                Console.WriteLine("Please enter the package weight using numbers only:");
            }
            //package has to be under 50 lbs to be shipped
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            else
            {
                 //getting all package info from user and making sure it's a number. storing all info.
                Console.WriteLine("What is the width of your package?");
                decimal packageWidth;
                while (!decimal.TryParse(Console.ReadLine(), out packageWidth))
                {
                    Console.WriteLine("Please enter the package width using numbers only:");
                }
                Console.WriteLine("What is the height of your package?");
                decimal packageHeight;
                while (!decimal.TryParse(Console.ReadLine(), out packageHeight))
                {
                    Console.WriteLine("Please enter the package height using numbers only:");
                }

                Console.WriteLine("What is the length of your package?");
                decimal packageLength;
                while (!decimal.TryParse(Console.ReadLine(), out packageLength))
                {
                    Console.WriteLine("Please enter the package length using numbers only:");
                }
               // calcuating the quote 
                decimal packageVolume = packageWidth * packageHeight * packageLength;
                decimal quote = packageWeight * packageVolume / 100;
                //outputting the quote to the user
                Console.WriteLine($"Your estimated total for shipping this package is: ${quote}\nThank you!");

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //storing current datetime in "now"
            DateTime now = DateTime.Now;
            //getting the number to add to hour
            Console.WriteLine("Todays date and time is: " + now);
            Console.WriteLine("Enter a number to add to the hours of the day, then I will tell you what time it would be.");
            //converting input to int
            string input = Console.ReadLine();
            int addHours = Convert.ToInt32(input);
            //adding hours and storing it in newTime
            DateTime newTime = now.AddHours(addHours);
            //outputting new time
            Console.WriteLine("When {0} hours is added it will be {1}", addHours, newTime);
            Console.ReadLine();
        }
    }
}

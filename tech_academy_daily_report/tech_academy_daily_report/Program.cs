using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tech_academy_daily_report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables seperated for readability
            string name;
            string course;
            int pageNumber; 
            bool needHelp;
            string positiveExperiences;
            string additionalFeedback;
            int hoursStudied;

            // all of the console.writeline and console.readline statements
            Console.WriteLine("Tech Academy");
            Console.WriteLine("Welcome to the Tech Academy Daily Report!");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            course = Console.ReadLine();
            Console.WriteLine("What page number?");
            pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            additionalFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            hoursStudied = Convert.ToInt32(Console.ReadLine());
            // final message output letting user know their answers have been recorded
            Console.WriteLine("Hello, " + name + ", you are in the " + course + " course, on page number: " +
                pageNumber + ". You studied " + hoursStudied + " hours today. Help needed: " + needHelp + ". Positive Experiences: " 
                + positiveExperiences + ". Additional Feedback: " + additionalFeedback);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            
        }
    }
}

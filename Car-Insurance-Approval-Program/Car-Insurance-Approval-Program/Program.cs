using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {   //getting info about user
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            bool hasDui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            //creating a bool which is equal to the result of calling the method 
            //checkIfQualified and passing in the user input age, hasdui and speedingtickets as arguments
            bool isQualified = checkIfQualified(age, hasDui, speedingTickets);
            //outputting the result of the isQualified to the user
            Console.WriteLine($"Qualified?\n{isQualified}");
            //method that is called to check car insurance qualification
            //it takes the parameters age, dui status and number of speeding tickets
            //does the logic and returns true or false
            bool checkIfQualified(int applicantAge , bool applicantDuiStatus, int applicatantSpeedingTickets)
            {
                //age must be over 15 AND dui status false AND speeding tickets of 3 or less to return true
                if (applicantAge > 15 && applicantDuiStatus == false && applicatantSpeedingTickets <= 3)
                {
                    return true;
                }
                //otherwise return false, they are not qualified for car insurance
                else
                {
                    return false;
                }
            }


        }
    }
}

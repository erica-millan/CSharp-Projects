using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    //Person class with properties and method to calculate annual salary
    public class Person
    {
        //properties to hold the hourly rate and weekly hours worked for each person
        //getters and setters allow us to access and modify these
        //properties when creating person objects and calculating their annual salaries
        public decimal HourlyRate { get; set; }
        public decimal WeeklyHoursWorked { get; set; }


        //constructor runs when you create an instance of the class (person object)
        //and it assigns values to the objects properties with the
        //values passed in as parameters when creating the object

        //Constructor for the Person class that takes hourly rate and weekly hours worked as parameters
        public Person(decimal hourlyRate, decimal weeklyHoursWorked)
        {
            HourlyRate = hourlyRate;
            WeeklyHoursWorked = weeklyHoursWorked;
        }

        //Method that returns the annual salary based on the hourly rate and weekly hours worked
        //main program will call this method with the hourly rate and weekly hours worked for each
        //person as parameters and it will return the calculated annual salary for each person
        public static decimal CalculateAnnualSalary(decimal hourlyRate, decimal weeklyHours)
        {
            return hourlyRate * weeklyHours * 52;
        }

        //this method gets called with the annual salaries of p 1 and p 2, compared and returns true or false to main program
        public static bool p1GreaterThanp2(decimal p1AnnualSalary, decimal p2AnnualSalary)
        {
            if (p1AnnualSalary > p2AnnualSalary)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

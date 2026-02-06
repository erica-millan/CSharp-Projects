using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");
            //gettuing user input for person 1 and person 2
            Console.WriteLine("Person 1 hourly rate?");
            decimal p1HourlyRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Person 1 hours worked per week?");
            decimal p1WeeklyHoursWorked = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Person 2 hourly rate?");
            decimal p2HourlyRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Person 2 hours worked per week?");
            decimal p2WeeklyHoursWorked = Convert.ToDecimal(Console.ReadLine());

            //Creating a person using the Person class constructor for neater code and to
            //practice the using classes and constucter for c#. (learned in python course)
            //creating person 1 and person 2 objects using the Person class constructor
            //they will hold the information/properties of the objects and
            //we can use them to call the method to calculate the annual salary
            Person person1 = new Person(p1HourlyRate, p1WeeklyHoursWorked);
            Person person2 = new Person(p2HourlyRate, p2WeeklyHoursWorked);

            // Call the calculate annual salary method for both persons
            // and store the results in corresponding variables
            decimal p1AnnualSalary = Person.CalculateAnnualSalary(p1HourlyRate, p1WeeklyHoursWorked);
            decimal p2AnnualSalary = Person.CalculateAnnualSalary(p2HourlyRate, p2WeeklyHoursWorked);

            // Display results
            Console.WriteLine("Person 1 annual salary: " + p1AnnualSalary);
            Console.WriteLine("Person 2 annual salary: " + p2AnnualSalary);

            //creating a boolean to store the result of calliing the method p1GreaterThanp2 to compare the annual salaries of person 1 and person 2
            //Method returns the result (true or false) and it gets stored in bool
            bool person1MakesMoreMoneyThanPerson2 = Person.p1GreaterThanp2(p1AnnualSalary, p2AnnualSalary);

            //outputting that result that was stored in boolean
            Console.WriteLine("Does Person 1 make more money than Person 2? " + person1MakesMoreMoneyThanPerson2);

        }
    }
}

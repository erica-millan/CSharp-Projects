using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list of at least 10 employees, at least 2 having the first name Joe
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Miller" },
                new Employee { Id = 2, FirstName = "Joe", LastName = "Anderson" },
                new Employee { Id = 3, FirstName = "Hanna", LastName = "Taylor" },
                new Employee { Id = 4, FirstName = "Johnathon", LastName = "Brown" },
                new Employee { Id = 5, FirstName = "Sarah", LastName = "Davis" },
                new Employee { Id = 6, FirstName = "Joe", LastName = "Wilson" },
                new Employee { Id = 7, FirstName = "Kendra", LastName = "Montano" },
                new Employee { Id = 8, FirstName = "Carlos", LastName = "Mendosa" },
                new Employee { Id = 9, FirstName = "Joe", LastName = "Ann" },
                new Employee { Id = 10, FirstName = "Henry", LastName = "Hall" }
            };

            //first need to create a list which will store all employees names Joe
            List<Employee> allJoes = new List<Employee>();

            //foreach loop that creates a new list of all employees with the first name “Joe”.
            //In your comparison statement, remember to reference the property of the object you are checking.

            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    allJoes.Add(emp); //adding all joes to allJoes list
                }
            }

            Console.WriteLine("This is a list of all Joes in the Employee list, using a foreach loop: \n");

            foreach (Employee joe in allJoes) 
            { 
                Console.WriteLine($"{joe.FirstName} {joe.LastName}"); 
            }

            /*
            get a list of joes with a lamda expression
            employees is the original list that I created with the 10 employees and
            the.findall is a method that belongs to List<T> it looks
            through each item in the list and checks the given condition returning a
            new list with the items that met conditions. 
            The lambda expression to the right of it is the "rule"
            it's saying take an employee and check if their first name is Joe. if
            condition is true, that row gets keeped. 
            result is stored in new list "joesLambda".
            */

            List <Employee> joesLambda = employees.FindAll(emp => emp.FirstName == "Joe");

            //Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List <Employee> idGreatThan5 = employees.FindAll(emp => emp.Id > 5);


        }
    }
}












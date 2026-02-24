using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create employee objects and also setting it's properties in one step (object initializer)
            //giving them the same id to test

            Employee employee1 = new Employee { id = "111", FirstName = "Erica", LastName = "M" };
            Employee employee2 = new Employee { id = "111", FirstName = "John", LastName = "Smith" };

            // third employee object with a different id than employee 1 and 2
            Employee employee3 = new Employee { id = "222", FirstName = "Andrew", LastName = "Miller" };

            Console.WriteLine("Employee 1 == Employee 2 (same ids):");
            Console.WriteLine(employee1 == employee2); // calling overloaded == operator prints true

            Console.WriteLine("\nEmployee1 == employee3 (different ids):");
            Console.WriteLine(employee1 == employee3); //calling overloaded == operator prints false

            Console.WriteLine("\nEmployee 1 != Employee 3 (different ids");
            Console.WriteLine(employee1 != employee3); //calling the != overloaded operator prints true

            Console.ReadLine();
        }
    }
}
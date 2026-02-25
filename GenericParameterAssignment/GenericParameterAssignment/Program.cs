using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameterAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with type “string”
            //as its generic parameter.

            Employee<string> employeeStr = new Employee<string>();

            //Assign a list of strings as the property value of Things.
            employeeStr.Things = new List<string>() { "List", "Of", "Strings" };

            //Instantiate an Employee object with type “int”
            //as its generic parameter. 
            Employee<int> employeeInt = new Employee<int>();

            //Assign a list of integers as the property value of Things.
            employeeInt.Things = new List<int> { 1, 2, 3 };

           // Create a loop that prints all of the Things to
           // the Console.

            foreach (var thing in employeeInt.Things)
            {
                Console.WriteLine(thing);
            }

            // Create a loop that prints all of the Things to
            // the Console.


            foreach (var thing in employeeStr.Things)
            {
                Console.WriteLine(thing);
            }

        }

    }
}

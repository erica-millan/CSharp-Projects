using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiate the employee object
            Employee employee = new Employee();

            //initialize the inherited properties
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //calling the inherited method 
            employee.SayName();
        }
    }
}

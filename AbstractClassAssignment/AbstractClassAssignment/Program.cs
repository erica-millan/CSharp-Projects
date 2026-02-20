using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiate employee
            Employee employee = new Employee();

            //setting values for firstname and lastname
            //we are outside of the object (employee class) so we have to use employee.firstname
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //calling say name
            employee.SayName();
        }
    }
}

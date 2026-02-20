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

            //using polymorphism to create an object of type IQuittable and call Quit() on it
            //an object can be of an interface type if it implements that specific interface.
            //an employee can be treated as an iquitable because employee implements the interface

            //creating an iquitable reference pointing to an employee object
            IQuittable quitter = employee;

            //call quit() 
            quitter.Quit();

        }
    }
}

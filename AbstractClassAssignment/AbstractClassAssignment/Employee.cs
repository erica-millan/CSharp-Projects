using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //employee class that inherits person
    public class Employee : Person
    {
        //Person has abstract method called SayuName which we HAVE to implement.
        //we have to use the override keyword, and that satisfied the contract that we will
        //use this abstract method
        public override void SayName() 
        {
            //we are inside the employee object itself so i dont have to say employee.first name etc
            //same at this.firstname, and this refers to the current object
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person
    {   //abstract class can never be instantiated
        //it can never be an object it's only meant to be inherited from.
        //Person is an abstract class
        //Never going to have an instance of Person
        //There will always be a specific person "type" like employee, manager, customer
        //which will all inherit from the person "base" class.

        //properties:
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //we want all inhertiing classes to have a sayname method because all people will have a name
        //this ensures all classes that inherit from person have a methd called sayname
        //abstract classes state that any class inheriting this class MUST implement this method
        //contract between base class(players) and inherting class (employee)
        public abstract void SayName();

    }
}

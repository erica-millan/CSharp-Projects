using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    internal class Employee
    {
        //operation overloading allows you to make your own implementation of plus and subtract. 
        //operators will be specific to an object you have created. 
        //ex- adding two objects together or using plus sign to add a player to a game.

        //creating employee class with ID, firstname, lastname properties
        public string id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //overload the == operator so it checks if two Employee objects are
        //equal by comparing their Id propery (comparison operators must be overloaded in pairs)
        // need to compare employee id properties to see if employee objects are equal

        //overloaded operator method:

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // null checking, if both employee objects are null then they are still equal
            if (employee1 is null && employee2 is null)
                return true;

            // if only one is equal they are not equal possibility of them both being equal is filtered out above
            if (employee1 is null || employee2 is null)
                return false;

            // comparing employee ids
            return employee1.id == employee2.id;
        }

        // comparison operators must be overloaded in pairs.
        //if you overload == then you have to overload !=
        //do not have to write the same logic twice just have to do the opposite of the logic with "!"
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            //use the same rules as the == operator but just flip the result
            //return the opposite answer of ==
            return !(employee1 == employee2);
        }
    }
}


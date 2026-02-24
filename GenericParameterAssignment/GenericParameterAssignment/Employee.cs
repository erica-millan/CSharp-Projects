
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameterAssignment
{
    public class Employee<T> //make employee a generic class
    {
        //create an employee class
        //make class take a generic type parameter

        //property called things with a data type as a 
        //generic list matching the generic type of the class.
        //now employee can hold a list of anything (strings, int, custom objects)

        public List<T> Things { get; set; }

    }
}

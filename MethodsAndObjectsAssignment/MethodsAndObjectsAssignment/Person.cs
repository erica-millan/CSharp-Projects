using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        public string FirstName {get; set;}
        public string LastName   {get; set;}


        public void SayName() 
        {
            //printing the name using instances first and last name.
            //using "this" to refer to the current onjects first and last name
            Console.WriteLine("Name: {0} {1}", this.FirstName, this.LastName);
        }
    }
}

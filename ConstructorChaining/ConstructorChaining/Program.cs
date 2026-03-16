using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {
        //constant variable, once this variable is set it can not be changed
        const int constVar = 10;

        //variable made with var keyword.
        //This is c#'s way of implicitly typing, it looks for the type, in this case it's a number and it gives it the data type (int)
        var varNum = 5;
 
        //create an object of Class1 passihng in only one number 
        //the constructor with 2 paramters will run automatically
        Class1 obj = new Class1(constVar);

        // call method on the object, this will print the stored variable
        obj.ShowVariable();

        Console.ReadLine();
    }
}


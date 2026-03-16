using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//have to create another class in order to demonstrate constructor chaining.
class Class1
{
    private int num1; //variable that stores a number
                      // constructor that takes in 2 variables
    public Class1(int num, string msg)
    {
        num1 = num;             
        Console.WriteLine(msg);
    }

    //second constructor that takes 1 parameter
    public Class1(int num)
        //: this(num, message) meants before running this constructor run other constructor first (constructor chaining)
        : this(num, "Outputting that 1 parameter called thr 2 parameter constructor.")
    {
       //other constructor does work that would have been here
    }
    //method that prints the number
    public void ShowVariable()
    {
        Console.WriteLine("Stored variable : " + num1);
    }
}

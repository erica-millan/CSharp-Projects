using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class Math_Operations
    {
        //all methods have the same name

        //takes an integer does math and returns an int
        public static int mathOp(int num) 
        {
            return num + 10;
        }

        //takes in a decimal, does math and converts to int and returns as an int
        public static int mathOp(decimal num)
        {
            decimal result = num / 2;
            return (int) result;
        }

        //takes in a string converts to int does math and returns as an intr
        public static int mathOp(string num)
        {
            int converted = Convert.ToInt32(num);
            return converted * 10;
        }

    }
}

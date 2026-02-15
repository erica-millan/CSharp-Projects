using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Calling_methods_assignment
{
    public class Math_Operations
    {   //creating all methods
        //All methods take in paramter named num which will be user input
        public static decimal AddTen(decimal num)
        {   //add 10 to user input and return
            return num + 10 ;
        }

        public static decimal MultiplyByTen(decimal num)
        {   //mult by 10 user input and return
            return num * 10;
        }

        public static decimal DivideByTwo(decimal num)
        {   //divide by 2 user input and return
            return num / 2 ;
        }

    }
}

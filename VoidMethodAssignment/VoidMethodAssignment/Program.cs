using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiating mathoperations class setting instance equal to the "op" variable
            MathOperations op = new MathOperations();

            //calling method passing numbers
            op.addNumbers(1, 1);

            //calling methods using named paramters
            op.addNumbers(op1: 7, input: 3);
        }
    }
}

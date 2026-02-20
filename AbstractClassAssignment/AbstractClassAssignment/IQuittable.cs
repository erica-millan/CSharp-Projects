using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //An interface is very similar to an abstract class
    //There are no implementation details in an interface
    //biggest reason to use interface over abstract class is the .Net framework
    //.Net framework doesn't support multiple inheritance
    //One class can inherit from ONLY one other class (classes can not have muliple base classes)
    //if you needed to tweak a base class to meet a need for an inherting class you can't 
    //becuase you affect every class that's inherting from it.
    internal interface IQuittable
    {
        //if we add iquitable as an interface it does not have to be implemented in every inherited class
        //.net framework supports multiple inheritance of interfaces

        //void method called quit, everything is public in interfaces dont have to write public
        //every class that implements iquitable HAS to implement this method
        //has to take away the same parameter and return a void
       
        void Quit();


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadAssignment
{
    //creating a static class named sound that outputs sounds
    //can't be instantiated
    //only contains static members
    public static class Sound
    {
        //creating static methods that I will call from the main program
        public static void Zap()
        {
            Console.WriteLine("ZAPPPPP.");
        }

        public static void Clink()
        {
            Console.WriteLine("Clinkkkk.");
        }

        public static void Wham()
        {
            Console.WriteLine("WHAMMMM.");
        }
    }
}

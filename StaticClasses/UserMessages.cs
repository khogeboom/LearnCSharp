using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class UserMessages
    {
        public static void DisplayHeader()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("** Welcome to Static Classes Demo **");
            Console.WriteLine("************************************");
        }

        public static void DisplayFooter()
        {
            Console.WriteLine("Press any key to exit...");
            Console.WriteLine("************************************");
            Console.WriteLine("**   Written by: Bozo the Clown   **");
            Console.WriteLine("************************************");
        }
    }
}

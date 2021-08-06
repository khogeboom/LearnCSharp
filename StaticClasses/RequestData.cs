using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class RequestData
    {
        public static string GetAString(string message)
        {
            message = message.TrimEnd();
            Console.Write($"{ message } ");
            string output = Console.ReadLine();
            return output;
        }

        public static int GetAnInt(string message)
        {
            message = message.TrimEnd();
            Console.Write($"{ message } ");
            int output = int.Parse(Console.ReadLine());
            return output;
        }

        public static double GetADouble(string message)
        {
            message = message.TrimEnd();
            Console.Write($"{ message } ");
            double output = double.Parse(Console.ReadLine());
            return output;
        }

        private static void YouWontSeeMe()
        {

        }
    }
}

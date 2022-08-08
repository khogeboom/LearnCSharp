using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class RequestData
    {
        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }

        public static double GetADouble(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();

            bool isDouble = double.TryParse(numberText, out double output);

            while (isDouble == false)
            {
                Console.WriteLine("That was not a valid number. Please try again.");
                Console.Write(message);
                numberText = Console.ReadLine();
                isDouble = double.TryParse(numberText, out output);
            }

            return output;
        }

        public static char GetOperation(string message)
        {
            Console.Write(message);
            char operation = Console.ReadLine()[0];
            return operation;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = RequestData.GetAString("What is your first name: ");

            UserMessages.ApplicationStartMessage(firstName);

            double x = RequestData.GetADouble("Please enter your first number: ");
            double y = RequestData.GetADouble("Please enter your second number: ");

            double result = CalculateData.Add(x, y);
            // if your class/method doesn't pop up as you type then you either didn't made it static or public

            UserMessages.PrintResultMessage($"The sume of {x} and {y} is {result}");

            char operation = RequestData.GetOperation("Please enter the symbol for your operation (+, -, *, /): ");
            if (operation == '+')
                CalculateData.Add(x, y);
            else if (operation == '-')
                CalculateData.Subtract(x, y);
            else if (operation == '*')
                CalculateData.Multiply(x, y);
            else if (operation == '/')
                CalculateData.Divide(x, y);

            Console.ReadLine();
        }
    }
}

// PRO TIP: Use class files to separate your code so that each class and each method has its own purpose

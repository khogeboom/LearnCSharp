using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMessages.DisplayHeader();
            
            //string first = RequestData.GetAString("What is your first name?");
            //string last = RequestData.GetAString("What is your last name?");
            
            int x = RequestData.GetAnInt("Enter a value for x: ");
            int y = RequestData.GetAnInt("Enter a value for y:");
            
            Console.WriteLine(MathFunctions.Add(x, y));
            MathFunctions.Add(1, 2);
            MathFunctions.Subtract(7, 8);
            
            Console.WriteLine($"The last result was: {MathFunctions.lastResult}");
            
            UserMessages.DisplayFooter();
            Console.ReadKey();
        }
    }
}

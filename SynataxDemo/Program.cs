using System;

namespace SynataxDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings
            string firstName = "";
            string lastName = "";

            // Prompt user
            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();

            // String concatenation example (in general don't use this!!!!)
            Console.WriteLine("Hello, " + firstName + " " + lastName + "!");

            // String interpolation example (use this!)
            Console.WriteLine($"Hello, { firstName } { lastName }!");

            // Escape sequence with backslash
            string filePath = @"C:\Temp\test.txt";

            // String concatentation
            Console.WriteLine("File location: " + filePath);

            // String interpolation
            Console.WriteLine($"File location: { filePath }");

            // Integers -- whole numbers
            int age;

            Console.Write("What is your age? ");
            string ageText = Console.ReadLine();

            // Convert string --> int (Trusting the user to enter a valid int)
            //age = int.Parse(ageText);

            //int.TryParse(ageText, out int age); <-- You can declare the out variable inline
            bool isValidAge = int.TryParse(ageText, out age);

            if (isValidAge)
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("You really are trying to fool me, ha ha ha.");
            }

            // basic math
            int x = 5;
            int y = 10;
            int sum = x + y;
            int diff = x - y;
            int mult = x * y;
            int quotient = x / y;
            int remainder = y % x;

            // increments
            x = x + 1;
            x += 1;

            // age = 7.5; Not allowed
            age = -32;

            // characters
            //char aChar = 'k';

            Console.WriteLine(filePath[0]);
            Console.WriteLine(filePath[1]);
            //Console.WriteLine(filePath[22]);

            // Doubles
            //double avgWordsPerMin = 33.33;

            //// Decimal
            //decimal cost = 3.33M;

            //// booleans
            //bool theTruth = true;
            //bool notTheTruth = false;

            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);

            DateTime thirtyDaysAgo = rightNow.AddDays(-30);
            Console.WriteLine(thirtyDaysAgo);

            // Initialization-- explicit, var, and new format
            Tuple<string, string, string> sampleTuple = new Tuple<string, string, string>("Hello", "Goodbye", "Farewell");
            var sampleTuple2 = new Tuple<string, string>("Hello", "Goodbye"); // OK use of var, bc type is obvious from right side.
            Tuple<string, string> sampleTuple3 = new("Hello", "Goodbye"); // New format for condensing code.

            // Bad use of var
            var sixtyDaysAgo = rightNow.AddDays(-60);

            // Tuples
            Console.WriteLine(sampleTuple);


            // End program
            Console.WriteLine("App completed, press any key to exit.");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcome();

            string first = PromptUser("What is your first name?");
            string last = PromptUser("What is your last name?");

            OptionalSayHello(first, last);
            OptionalSayHello(first);

            PrintNames();

            int x = OutParamDemo(1, 2, out int q);
            Console.WriteLine($"Value of x: {x}");
            Console.WriteLine($"Value of q: {q}");

            ExitApp();
            Console.WriteLine("You should not see me!");
        }

        private static void ExitApp()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private static void PrintWelcome()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("** Welcome to the Static Methods Demo **");
            Console.WriteLine("****************************************");
        }

        private static void SayHello(string firstName, string lastName)
        {
            Console.WriteLine($"Hello, { firstName } { lastName} ");
        }

        private static List<string> GetNames()
        {
            List<string> output = new List<string>
            {
                "Brian",
                "Kasey",
                "Roger",
                "Steve"
            };

            return output;
        }

        private static void PrintNames()
        {
            foreach (var name in GetNames())
            {
                Console.WriteLine(name);
            }
        }

        private static int OutParamDemo(int x, int y, out int z)
        {
            z = x + y;
            return x * y;
        }

        private static void OptionalSayHello(string firstName, string lastName = "Schrute")
        {
            Console.WriteLine($"Hello, { firstName } { lastName} ");
        }

        private static string PromptUser(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }
    }
}

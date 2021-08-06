using System;
using System.Collections.Generic;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = new string[5]; // 0, 1, 2, 3, 4
            firstNames[0] = "Kasey";
            firstNames[1] = "Brian";
            firstNames[2] = "Yelena";
            firstNames[3] = "Tor";
            firstNames[4] = "Ken";

            // for loops
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Value of i: {i}");
            }

            for (int i = 0; i < firstNames.Length; i++)
            {
                if (firstNames[i] == "Tor")
                {
                    // Use 'continue' to skip the rest of the loop, and "continue" from the top!
                    continue;
                }

                Console.WriteLine($"Hello, {firstNames[i]}");
            }

            // while alternative
            int j = 0;

            while (j < firstNames.Length)
            {
                Console.WriteLine($"Goodbye, {firstNames[j]}");
                j++;

                if (j == 2)
                {
                    // Use 'break' to exit the iteration early.
                    break;
                }
            }

            // foreach loops
            foreach (string name in firstNames)
            {
                Console.WriteLine($"Go away, {name}!");
            }

            List<Tuple<string, string>> clowns = new();
            clowns.Add(new Tuple<string, string>("Joe", "Puccio"));
            clowns.Add(new Tuple<string, string>("Ken", "Small"));

            foreach (var c in clowns)
            {
                Console.WriteLine($"I hate this clown: { c.Item1 } { c.Item2 }");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

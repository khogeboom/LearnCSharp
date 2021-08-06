using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            // string[] firstNames = new string[5]; // 0, 1, 2, 3, 4
            // firstNames[0] = "Kasey";
            // firstNames[1] = "Brian";
            // firstNames[2] = "Yelena";
            // firstNames[3] = "Tor";
            // firstNames[4] = "Ken";

            // Console.WriteLine($"My array has {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[3]}, {firstNames[4]}");

            // string data = "Kasey,Brian,Yelena,Tor,Ken";
            // string[] firstNames = data.Split(',');

            // Console.WriteLine($"The fourth name is {firstNames[3]}");
            
            // int[] ages = new int[3];
            // ages[0] = 1;
            // ages[1] = 3;
            // ages[2] = 5;

            // Lists
            List<string> firstNames = new List<string>();
            firstNames.Add("Kasey");
            firstNames.Add("Brian");
            firstNames.Add("Ken");
            firstNames.Add("Tor");
            firstNames.Add("Yelena");
            firstNames.Remove("Brian");

            Console.WriteLine($"The fourth name is {firstNames[3].ToUpper()}");
            
            string data = "Kasey,Brian,Yelena,Tor,Ken";
            List<string> people = data.Split(',').ToList();

            Console.WriteLine($"The fourth person is {people[3]}");

            // Dictionaries
            Dictionary<string, string> coolPeople = new();
            coolPeople["Tor"] = "Math wizard.";
            coolPeople["Joe"] = "More special than cool.";
            coolPeople["Ken"] = "Very special person, like 'very' special.";

            Dictionary<int, string> historyEvents = new();
            historyEvents[1969] = "'Merica land on the moon.";

            Console.WriteLine($"In the year 1969, this happened: { historyEvents[1969] }");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            // Tuples -- we already covered.
        }
    }
}

using System;

namespace LearnLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isValidAge;
            //string ageText;

            //do
            //{
            //    Console.Write("What is your age? ");
            //    ageText = Console.ReadLine();

            //    isValidAge = int.TryParse(ageText, out int age);

            //} while (isValidAge == false);

            Console.Write("What is your age? ");
            string ageText = Console.ReadLine();
            
            bool isValidAge = int.TryParse(ageText, out int age);

            while (isValidAge == false)
            {
                Console.WriteLine("That was an invalid age, please try again, you idiot.");

                Console.Write("What is your age? ");
                ageText = Console.ReadLine();

                isValidAge = int.TryParse(ageText, out age);
            }

            Console.WriteLine($"You entered: {ageText}");
            Console.WriteLine("Press any key to exit :)");
            Console.ReadKey();
        }
    }
}

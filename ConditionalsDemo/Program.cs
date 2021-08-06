using System;

namespace ConditionalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            // If we wanted to permentnly change the casing.
            //firstName = firstName.ToLower();

            //// Conditionals
            //if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            //{
            //    firstName = "Dwight";
            //    lastName = "Shrute";
            //}

            firstName = string.IsNullOrWhiteSpace(firstName) ? "Dwight" : firstName;
            lastName = string.IsNullOrWhiteSpace(lastName) ? "Shrute" : lastName;

            //int luckyNumber = 0;

            if (firstName.ToLower() == "brian")
            {
                Console.WriteLine($"Hello, { firstName }!");
                int luckyNumber = 13;
                Console.WriteLine($"Lucky number: { luckyNumber }");
            }
            else if (firstName.ToLower() == "kasey" && lastName.ToLower().Equals("hogeboom"))
            {
                Console.WriteLine($"Hello, { firstName }, welcome to C#!");
                int luckyNumber = 14;
                Console.WriteLine($"Lucky number: { luckyNumber }");
            }
            else if (firstName.ToLower() == "kasey")
            {
                Console.WriteLine($"Hello, { firstName }, who has a last name unfamiliar to me!");
                int luckyNumber = 15;
                Console.WriteLine($"Lucky number: { luckyNumber }");

                if (lastName.ToLower() == "smith")
                {
                    Console.WriteLine("Helo, Kasey Smith!");
                }
            }
            else if (firstName.ToLower() == "dwight")
            {
                Console.WriteLine($"Hello, { firstName }, ugh, go away!");
            }
            else
            {
                Console.WriteLine($"Hello, { firstName }, I don't know you!");
            }

            //luckyNumber = 14;

            //if (firstName.ToLower() == "brian" && lastName.ToUpper() == "FONTANA")
            //{
            //    Console.WriteLine($"Hello, { firstName } { lastName }!");
            //}
            //else if (firstName.ToLower() == "kasey" && lastName.ToLower().Contains('e'))
            //{
            //    Console.WriteLine($"Hello, { firstName } { lastName }, welcome to C#!");
            //}
            //else if (firstName.ToLower() == "dwight")
            //{
            //    Console.WriteLine($"Hello, { firstName }, ugh, go away!");
            //}
            //else
            //{
            //    Console.WriteLine($"Hello, { firstName }, I don't know you!");
            //}

            int age = 15;

            if (age > 50)
            {
                Console.WriteLine("Over the hill!");
            }
            else if (age > 100)
            {
                Console.WriteLine("Wow, how was the civil war?");
            }
            else if (age > 25 && age < 65)
            {
                Console.WriteLine("Hello to your new car insurance discount");
            }
            else if (age <= 17)
            {
                Console.WriteLine("You can't get into that \'R\' rated movie.");
            }

            switch (firstName.ToLower())
            {
                case "brian":
                    Console.WriteLine("Let's go Islanders!!!!");
                    break;
                case "kasey":
                    Console.WriteLine("I love NYC!!!!!!");
                    break;
                case "dwight":
                    Console.WriteLine("Ugh, raelly man, just go away already!");
                    break;
                default:
                    Console.WriteLine("Still have no idea who you are?!?!?!?!?!");
                    break;
            }

            // End program
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

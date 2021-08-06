using System;

namespace ClassPropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new("Joel");
            p.FirstName = "Billy";
            //p.LastName = "Joel";
            p.SSN = "012-34-5678";
            Console.WriteLine(p.FullName + " " + p.SSN);

            
            Console.WriteLine("Press any key...");
            Console.ReadKey();

            // Some change for github demonstration
        }
    }
}

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
            PersonModel person = new PersonModel();
            person.FirstName = "Tim";
            // person.LastName = "Corey";
            person.Age = 40;
            person.SSN = "123-45-6789";

            Console.WriteLine(person.FullName);
            Console.WriteLine(person.SSN);

            Console.ReadKey();
        }
    }
}

// PRO TIP: In classes, use auto-properties by default. Move to full properties when needed.
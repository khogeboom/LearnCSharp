using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "Enter your first name: ".RequestString();

            person.LastName = "Enter your last name: ".RequestString();

            person.Age = "What is your age: ".RequestInt(0, 120);


            Console.ReadLine();
        }
    }
}

// PRO TIP: Use the tools that make your code easier to read and quicker to develop.
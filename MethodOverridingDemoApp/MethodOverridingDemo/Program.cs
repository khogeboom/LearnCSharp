using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                Email = "iamtimcorey@gmail.com"
            };

            Console.WriteLine(person);

            Console.ReadLine();
        }
    }
}
// PRO TIP: If you are overriding every method, maybe you just needed an interface.
// HOMEWORK: Create a Person class and override the ToString method in it. Make it return the user's first and last name.
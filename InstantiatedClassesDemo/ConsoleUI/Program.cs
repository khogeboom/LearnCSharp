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
            // Building a house from the blueprint

            /* PersonModel person = new PersonModel();
            person.firstName = "Tim";
            PersonModel secondPerson = new PersonModel();
            secondPerson.firstName = "Sue";
            Console.WriteLine(person.firstName);
            Console.WriteLine(secondPerson.firstName); */

            /*List<PersonModel> people = new List<PersonModel>();
            PersonModel person = new PersonModel();    // Variable holds the street address
            person.firstName = "Tim";
            people.Add(person);
            person = new PersonModel();
            person.firstName = "Sue";
            people.Add(person);
            foreach(PersonModel p in people)
            {
                Console.WriteLine(p.firstName);
            } */

            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";
            string lastName = "";

            do
            {
                Console.Write("What is yous first name (or type exit to stop): ");
                firstName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    Console.Write("What is your last name: ");
                    lastName = Console.ReadLine();
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }
            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }


            Console.ReadLine();
        }
    }
}

// PRO TIP: In general, instantiated classes store data. Static classes are for stateless processing.
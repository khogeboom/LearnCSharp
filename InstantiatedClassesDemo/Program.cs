using System;
using System.Collections.Generic;

namespace InstantiatedClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example #1: Constructing Daffy & Porky
            PersonModel daffy = new PersonModel();
            daffy.FirstName = "Daffy";
            daffy.LastName = "Duck";
            daffy.EmailAddress = "Daffy.Duck@fiserv.com";
            //daffy.SayHello();

            PersonModel porky = new PersonModel();
            porky.FirstName = "Porky";
            porky.LastName = "Pig";
            porky.EmailAddress = "Porky.Pig@fiserv.com";

            List<PersonModel> people = new List<PersonModel>();
            people.Add(daffy);
            people.Add(porky);


            foreach (PersonModel p in people)
            {
                p.SayHello();
            }

            // Problem we are trying to solve... keeping track of data across multiple variables
            //List<string> firstNames = new List<string>();
            //List<string> lastNames = new List<string>();
            //List<string> emailAddresses = new List<string>();

            // Example #2: Using same PersonModel (looneyCharacter) to add Daffy and Porky to the same list
            List<PersonModel> morePeople = new List<PersonModel>();

            PersonModel looneyCharacter = new PersonModel();
            looneyCharacter.FirstName = "Daffy";
            looneyCharacter.LastName = "Duck";
            looneyCharacter.EmailAddress = "Daffy.Duck@fiserv.com";
            morePeople.Add(looneyCharacter);

            looneyCharacter = new PersonModel();
            looneyCharacter.FirstName = "Porky";
            looneyCharacter.LastName = "Pig";
            looneyCharacter.EmailAddress = "Porky.Pig@fiserv.com";
            morePeople.Add(looneyCharacter);

            foreach (PersonModel p in morePeople)
            {
                p.SayHello();
            }

            // Example #3: Constructing a person with parameters.
            PersonModel bugs = new PersonModel("Bugs", "Bunny");

            Console.ReadKey();
        }

        static void DemoMethod()
        {
            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";

            do
            {
                Console.Write("What is your first name (or type exit to stop): ");
                firstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                string lastName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }
            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                //ProcessPerson.GreetPerson(p);
            }
        }
    }
}


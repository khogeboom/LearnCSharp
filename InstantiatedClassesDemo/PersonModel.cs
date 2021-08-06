using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClassesDemo
{
    // Instantiated classes act as a blueprint for contructing multiple instances based on this blueprint.
    public class PersonModel
    {
        //public string FirstName;
        //public string LastName;
        //public string EmailAddres;
        //public bool IsGreeted = false;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsGreeted { get; set; } = false;

        // Default constructor, provided if you don't provide one.
        public PersonModel()
        {
            
        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = $"{firstName}.{lastName}@fiserv.com";
        }


        public void SayHello()
        {
            Console.WriteLine($"Hello, {FirstName} {LastName}!");
        }
    }
}

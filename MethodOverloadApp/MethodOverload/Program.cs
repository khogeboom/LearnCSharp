using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Method Overloading = you can have two methods with the same name as long as the signature line is different

namespace MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("Tim", "Corey");
            person.GenerateEmail("gmail.com", true);
            Console.WriteLine(person.Email);


            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public PersonModel()
        {

        }
        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public PersonModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateEmail()
        {
            GenerateEmail("aol.com", false);
        }

        public void GenerateEmail(string domain)
        {
            GenerateEmail(domain, false);
        }


        public void GenerateEmail(bool firstInitialMethod)
        {
            GenerateEmail("aol.com", false);
        }

        public void GenerateEmail(string domain, bool firstInitialMethod)
        {
            if (firstInitialMethod == true)
                Email = $"{FirstName.Substring(0, 1)}{LastName}@{domain}";
            else
                Email = $"{FirstName}.{LastName}@{domain}";
        }
    }
}

// PRO TIP: Overloads make things easier for the user. Behind the scenes, just make sure you keep your code dry.
// HOMEWORK: Create an EmployeeModel class. Create three different constructors that take in different amounts of data.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    // "internal" classes only accessible within assembly
    // protected can be access from any child/grandchild/etc classes
    // "private protected" = you have access to something if its in the class or a derived class in the current assembly
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers 

    public class DataAccess
    {
        protected internal string GetConnectionString()
        {
            return "Sensitive data";
        }
    }

    public class Person
    {
        protected string formerLastName = "";
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private string _ssn;

        public string SSN
        {
            get 
            {
                return $"*** - ** - {_ssn.Substring(_ssn.Length - 4)}";
            }
            set 
            { 
                _ssn = value; 
            }
        }

        public void ChangeLastName(string newLastName)
        {
            formerLastName = LastName;
            LastName = newLastName;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName}");
        }

        public void SavePerson()
        {
            DataAccess data = new DataAccess();
            string connection = data.GetConnectionString();
        }
    }
}

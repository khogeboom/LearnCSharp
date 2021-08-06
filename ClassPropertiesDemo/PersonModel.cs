using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPropertiesDemo
{
    public class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { get; private set; }

        private string _middleName;
        public string MiddleName
        {
            get { return _middleName; }
            private set { _middleName = value; }
        }


        private string _password;
        public string Password
        {
            set 
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Password must be >3 characters.");
                }
                _password = value; 
            }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        private string _ssn;
        public string SSN
        {
            get 
            {
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output;
            }
            set { _ssn = value; }
        }



        public PersonModel()
        {

        }

        public PersonModel(string lastName)
        {
            LastName = lastName;
        }
    }
}

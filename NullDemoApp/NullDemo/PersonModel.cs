using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullDemo
{
    internal class PersonModel
    {
        public int ID { get; set; }
        // int default value is 0
        public string Name { get; set; }
        // string default value is null
        public bool IsValid { get; set; }
        // boolean default value is false

    }
}

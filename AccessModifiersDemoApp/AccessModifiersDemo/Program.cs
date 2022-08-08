using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace AccessModifiersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            // DataAccess data = new DataAccess();
            // cannot talk to class if declared "internal"
            // only classes inside assembly can access "internal" classes

            person.SavePerson();

            Console.ReadLine();
        }
    }
}
 // PRO TIP: Identify who needs an object in order to understand which modifier it needs.
 // HOMEWORK: Create a Class Library and a Console application. Create a public class with members that have different modifiers. Try each out.
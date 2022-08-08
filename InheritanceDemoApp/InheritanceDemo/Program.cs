using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            smartphone.PlaceCall(); // Smartphone is a grandchild of Phone

            Landline landline = new Landline();
            landline.EndCall(); // Landline is a child of Phone

            Phone phone = new Smartphone();
            // a child should always be able to fill in for a parent/grandparent

            List<Phone> phones = new List<Phone>();
            phones.Add(new Cellphone());
            phones.Add(new Smartphone());
            foreach (var p in phones)
            {
                if (p is Cellphone cell)
                {
                    cell.Carrier = "";
                }
                if (p is Smartphone sp)
                {
                    sp.ConnectToInternet();
                }
            }


            Console.ReadLine();
        }
    }
}
// PROP TIP: Use inheritanc spaeringly and follow the "is a" rule.
// HOMEWORK: Create a vehicle class, a car class, a boat class, and a motorcycle class. Identify what inheritance should happen, if any, and wire it up.

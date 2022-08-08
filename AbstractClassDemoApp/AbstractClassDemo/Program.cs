using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Abstract Class = a class that's a base/foundational class that you build upon (it's not complete on its own)
// cannot instantiate abstract classes directly

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.ProductName = "A Tale of Two Cities";

            Car car = new Car();
            car.VIN = "";
            car.Manufacturer = "";
            // Car inherits from abstract Vehicle class
            // cannot create instance of Vehicle but can for child Car class

            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactered { get; set; }

    }

    public class Car : Vehicle
    {
        public int NumOfWheels { get; set; } = 4;

    }
}

// PRO TIP: Abstract classes are great starting points. Just don't forget to follow the "is a" rule.
// HOMEWORK: Create an Abstract Class that has an Interface applied to it. When instantiating the child class, store it using the interface type.
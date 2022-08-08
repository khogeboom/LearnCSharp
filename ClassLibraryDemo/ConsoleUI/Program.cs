using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using DemoLibrary.Models; // need to add as a reference under reference folder in ConsoleUI
// UIs reference libraries but libraries should not reference UIs
// Class libraries are how we share data

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel(); // from DemoLibrary.Models
            Calculation.Add(4, 3);

            Console.ReadLine();
        }
    }
}

// PRO TIP: Store as much of your code in class libraries as possible
// Exception: In general, do not put user interface cod in your class library
// Do just the work in the class library andleave the reading/writing to the console to the UI

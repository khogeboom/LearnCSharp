using System;
using System.Collections.Generic;
using FoundationInfo; // from Calculations class

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>(); // from System.Collections.Generic
            Console.WriteLine(); // from System

            PersonModel person = new PersonModel();

            Calculations.Add(4, 3); // from FoundationInfo
            
            Console.ReadLine();
        }
    }
}

// PRO TIP: Use namespaces to organize your application logically
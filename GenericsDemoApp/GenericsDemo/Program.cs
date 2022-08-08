using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Generics = does not define what type is (i.e. List<> needs you to specify the type)

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = FizzBuzz("tests");
            Console.WriteLine($"Tests: {result}");

            result = FizzBuzz(123);
            Console.WriteLine($"123: {result}");

            result = FizzBuzz(true);
            Console.WriteLine($"true: {result}");

            result = FizzBuzz(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            Console.WriteLine($"PersonModel: {result}");


            GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
            peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "Tim", HasError = true });

            foreach (var item in peopleHelper.RejectedItems)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} was rejected");
            }


            Console.ReadLine();
        }

        private static string FizzBuzz<T>(T item)
        {
            // <T> = the method will utilize a generic type
            // can use T in code like any other type
            // can be any letter (doesn't have to be T)
            // can return generic type

            // 3 - Fizz, 5 - Buzz, 3&5 - FizzBuzz

            int itemLength = item.ToString().Length;
            string output = "";

            if (itemLength % 3 == 0)
                output = "Fizz";
            else if (itemLength % 5 == 0)
                output += "Buzz";

            return output;
        }
    }

    public class GenericHelper<T> where T: IErrorCheck
        // order matters here
        // "new()" means it has an empty constructor
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<T> RejectedItems { get; set; } = new List<T>();

        public void CheckItemAndAdd(T item)
        {
            if (item.HasError == false)
                Items.Add(item);
            else
                RejectedItems.Add(item);
        }
    }

    //only classes can implement interfaces
    public interface IErrorCheck
    {
        bool HasError { get; set; }

    }

    public class CarModel : IErrorCheck
    {
        public string Manufacturer { get; set; }
        public int YearManufactured { get; set; }
        public bool HasError { get; set; }

    }

    public class PersonModel : IErrorCheck
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasError { get; set; }

    }
    
}
// PRO TIP: The standard generic variable is T but you can choose any letter you want.
// HOMEWORK: Create a generic method that takes in an item and calls the ToString() method and prints that value to the Console.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapUpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel> 
            { 
                new PersonModel { FirstName = "Tim", LastName = "Coreydarnit", Email = "timcorey@gmail.com" },
                new PersonModel { FirstName = "Kasey", LastName = "Hogeboom", Email = "kaseyhogeboom@gmail.com" },
                new PersonModel { FirstName = "Brian", LastName = "Fontana", Email = "brianfontana@gmail.com" }
            };

            List<CarModel> cars = new List<CarModel>
            {
                new CarModel {Manufacturer = "Toyota", Model = "DARNCorolla" },
                new CarModel {Manufacturer = "Toyota", Model = "Highlander" },
                new CarModel {Manufacturer = "Ford", Model = "heckMustang" }
            };

            DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
            peopleData.BadEntryFound += PeopleData_BadEntryFound;
            peopleData.SaveToCSV(people, @"C:\Users\Kasey\source\repos\WrapUpDemoApp\WrapUpDemo\people.csv");

            DataAccess<CarModel> carData = new DataAccess<CarModel>();
            carData.BadEntryFound += CarData_BadEntryFound;
            carData.SaveToCSV(cars, @"C:\Users\Kasey\source\repos\WrapUpDemoApp\WrapUpDemo\cars.csv");

            Console.ReadLine();
        }

        private static void CarData_BadEntryFound(object sender, CarModel e)
        {
            Console.WriteLine($"Bad entry found for {e.Manufacturer} {e.Model}");
        }

        private static void PeopleData_BadEntryFound(object sender, PersonModel e)
        {
            Console.WriteLine($"Bad entry found for {e.FirstName} {e.LastName}");
        }
    }

    public class DataAccess<T> where T: new()
    {
        public event EventHandler<T> BadEntryFound;
        public void SaveToCSV(List<T> items, string filePath)
        {
            List<string> rows = new List<string>();
            T entry = new T();
            var cols = entry.GetType().GetProperties();
            // creates list of columns (i.e. firstname, lastname, email)
            string row = "";

            foreach (var col in cols) // looping through the header names
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1); // will start at the strings second position
            rows.Add(row);

            foreach (var item in items)
            { // looping through of the models
                row = "";
                bool badWordDetected = false;
                foreach (var col in cols) // looping through each of the columns
                {
                    string val = col.GetValue(item, null).ToString();

                    badWordDetected = BadWordDetector(val);
                    if (BadWordDetector(val) == true)
                    {
                        BadEntryFound?.Invoke(this, item);
                        break;
                    }

                    row += $",{val}";
                }

                if (badWordDetected == false)
                {
                    row = row.Substring(1);
                    rows.Add(row);
                }
            }

            File.WriteAllLines(filePath, rows);
        }

        private bool BadWordDetector(string stringToTest)
        {
            bool output = false;
            string lowerCaseTest = stringToTest.ToLower();

            if (lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
                output = true;

            return output;
        }
    }
}
// PRO TIP: Generics and events can make your code more flexible to future changes.
// HOMEWORK: Recreate the project we just did without looking back at the video. Make sure to make small tweaks.
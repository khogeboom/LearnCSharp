using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileAccessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example #1
            //StreamReader fileReader = new StreamReader("People.txt");
            //string line;

            //while ((line = fileReader.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}

            //fileReader.Dispose();

            // Example #2
            //StreamReader fileReader = new StreamReader("People.txt");

            //while (fileReader.Peek() >= 0)
            //{
            //    //string line = fileReader.ReadLine();
            //    //Console.WriteLine(line);

            //    Console.WriteLine(fileReader.ReadLine());
            //}

            //fileReader.Dispose();

            // Example #3
            using (StreamReader fileReader = new StreamReader("People.txt"))
            {
                while (fileReader.Peek() >= 0)
                {
                    Console.WriteLine(fileReader.ReadLine());
                }
            }

            // Example #4
            Console.WriteLine(File.ReadAllText("People.txt"));

            // Example #5
            List<string> data = File.ReadAllLines("People.txt").ToList();
            data.Add("Cookie Monster");

            foreach (var person in data)
            {
                Console.WriteLine(person);
            }

            File.WriteAllLines("People-updated.txt", data);

            Console.WriteLine("Whatever, you know what to do...");
            Console.ReadLine();
        }
    }
}

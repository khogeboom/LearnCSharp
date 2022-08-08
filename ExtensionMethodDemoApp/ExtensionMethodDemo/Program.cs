using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // when you attach it to a string the "this" keyword passes that string into the method
            "Hello World".PrintToConsole();

            HotelRoomModel room = new HotelRoomModel();
            room.TurnOnAir().SetTemperature(72).OpenShades();
            room.TurnOffAir().CloseShades();
            // since your returning the same object you can perform multiple methods on it

            Console.ReadLine();
        }
    }

    public class HotelRoomModel
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; }

    }

    public static class ExtensionSamples
    {
        // "this" = indicates that it is an extension method
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
        {
            room.IsAirRunning = true;
            return room;
        }

        public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
        {
            room.IsAirRunning = false;
            return room;
        }

        public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)
        {
            room.Temperature = temperature;
            return room;
        }

        public static HotelRoomModel OpenShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = true;
            return room;
        }

        public static HotelRoomModel CloseShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = false;
            return room;
        }
    }
}

// PRO TIP: Extension methods make it easier to call things and to read your code.
// HOMEWORK: Create the following chain using extension methods: person.SetDefaultAge().PrintInfo();
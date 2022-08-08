using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// An interface is a contract
// Classes implement interfaces

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Keyboard> controllers = new List<Keyboard>();

            Console.ReadLine();
        }
    }

    public interface IComputerController
    {
        void Connect();
        void CurrentKeyPressed();
    }

    public class Keyboard : IComputerController
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }
    }

    public class GameController
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }
    }
}

using System;

namespace MethodOverridingDemo
{
    public abstract class Car
    {
        // if you're going to change it sometimes use virtual
        public virtual void StartCar()
        {
            Console.WriteLine("Turn key and start");
        }

        // if you're going to change it everytime use abstract method or interface
        public abstract void SetClock();
    }
}

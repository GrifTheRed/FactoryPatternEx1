using System;
namespace FactoryPatternEx1
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            Console.WriteLine("The car is driving!");
        }
    }
}


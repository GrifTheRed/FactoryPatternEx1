using System;
namespace FactoryPatternEx1
{
    public class Motocycle : IVehicle
    {
        public Motocycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine(" The motorcycle is revving up!");
            Console.WriteLine("Vroom, Vroom");
        }
    }
}


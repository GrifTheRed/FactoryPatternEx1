using System;

namespace FactoryPatternEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of tires for desired vehicle you wish to create");


                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while (input == false);

             var vehicle = Vehicle_Factory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}


using System;
namespace FactoryPatternEx1
{
    public static class Vehicle_Factory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 2:
                    return new Motocycle();
                case 3:
                    return new Three_Wheeler();
                case 4:
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}


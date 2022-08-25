using System;
namespace FactoryPatternEx1
{
    public class Three_Wheeler : IVehicle
    {
        public Three_Wheeler()
        {
        }


        public void Drive()
        {
            Console.WriteLine("If you're driving one of these you are going to wreck, it's a fact!");
        }
    }
}


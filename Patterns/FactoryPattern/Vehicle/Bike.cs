using System;

namespace Patterns
{
    public class Bike : IVehicle
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
        public void FuelConsumption()
        {
            Console.WriteLine("Fuel Consumption for the Bike : " + 0);
        }
    }
}

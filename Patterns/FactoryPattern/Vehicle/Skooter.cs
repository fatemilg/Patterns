using System;

namespace Patterns
{
    public class Skooter : IVehicle
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
        public void FuelConsumption()
        {
            Console.WriteLine("Fuel Consumption for the Scooter : " + 0);
        }
    }
}

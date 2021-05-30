using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    public class Car : IVehicle
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Car : " + miles.ToString() + "km");
        }
        public void FuelConsumption()
        {
            Console.WriteLine("Fuel Consumption for the Car : " + 20);
        }
    }
}

using Patterns.FactoryPattern.VehicleFactory;
using System;

namespace Patterns
{
    public class SkooterFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Skooter();
        }

    }


}

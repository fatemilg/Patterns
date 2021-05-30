using Patterns.FactoryPattern.VehicleFactory;

namespace Patterns
{
    public class BikeFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }


}

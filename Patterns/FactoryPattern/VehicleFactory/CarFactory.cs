using Patterns.FactoryPattern.VehicleFactory;

namespace Patterns
{
    public class CarFactory:IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }
    }


}

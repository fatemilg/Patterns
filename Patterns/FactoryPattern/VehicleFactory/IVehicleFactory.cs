using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FactoryPattern.VehicleFactory
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }
}

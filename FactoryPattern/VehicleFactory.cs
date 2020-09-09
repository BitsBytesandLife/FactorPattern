using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    static class VehicleFactory
    {

        public static IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "motorcycle":
                    return new Motorcycle();
                case "big rig":
                    return new BigRig();
                default:
                    return new Car();
            }
        }
    }
}

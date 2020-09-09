using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        { 

            var vehicleType = ValidateInput.ValidationVehicleChoice("What type of Vehicle do want to make?").ToLower();
            IVehicle mustang = VehicleFactory.GetVehicle(vehicleType);
            
            mustang.Drive();

            vehicleType = ValidateInput.ValidationVehicleChoice("What type of Vehicle do want to make?");
            IVehicle goldWing = VehicleFactory.GetVehicle(vehicleType);
           
            goldWing.Drive();

            vehicleType = ValidateInput.ValidationVehicleChoice("What type of Vehicle do want to make?");
            IVehicle peterbilt = VehicleFactory.GetVehicle(vehicleType);
           
            peterbilt.Drive();

        }

    }
}

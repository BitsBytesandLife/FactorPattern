using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class BigRig : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Big Rig!");
        }
    }
}

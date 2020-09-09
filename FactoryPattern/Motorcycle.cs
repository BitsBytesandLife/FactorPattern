using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Motorcycle!");
        }
    }
}

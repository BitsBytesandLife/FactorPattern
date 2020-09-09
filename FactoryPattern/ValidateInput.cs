using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class ValidateInput
    {

        public static string ValidationVehicleChoice(string question)

        {

            string[] vehicleType = { "car","motorcycle","big rig"};

            while (true)
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine().Trim();

                if (vehicleType.Contains(userResponse))
                {   
                    return userResponse;
                }

            }
        }


    }
}

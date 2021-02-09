using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class Airport
    {

        public int MaxVehicle { get; set; }

        public List<AerialVehicle> Vehicles = new List<AerialVehicle>();

        public string AirportCode { get; set; }




        public string AllTakeOff()
        {
            return "The current code";
        }

        public string Land(AerialVehicle a)
        {
            return "The current vehicle gone";

        }

        public string Land(List<AerialVehicle> landing)
        {
            return "The air vehicle has finally landed";
        }

        public string TakeOff()
        {
            return "Vechicle has left the airport";
        }


    }
}


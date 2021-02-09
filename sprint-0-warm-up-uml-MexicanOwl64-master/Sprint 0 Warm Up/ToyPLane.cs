using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Sprint_0_Warm_Up
{
    class ToyPlane : Airplane
    {
        public int maxAltitude = 50;

        public int CurrentAltitude { get; set; }
        public bool isWoundUP { get; set; }
        public string About()
        {
            WriteLine("This OOPFlyingVehicle.ToyPlane has a max altitude of " + maxAltitude + ".");
            WriteLine("It's current altitude is " + CurrentAltitude + " ft");
            return "OOPFlyingVehicleMidterm.Airplane engine is started";
        }

        public string getWindUpString()
        {
            return "You are starting to wind up the vehicle";
        }

        public void StartEngine()
        {
            if (isWoundUP = true)
            {
                WriteLine("The toy plane is ready to go to the sky");
            }
            else
            {
                WriteLine("The string needs to be wound up to be working");
            }
        }

        public string TakeOff()
        {
            return "You are ready to move to the sky";
        }

        public ToyPlane()
        {

        }

        public void UnWind()
        {
            isWoundUP = false;
        }

        public void WindUp()
        {
            isWoundUP = true;
        }


    }
}

using System;
using static System.Console;
namespace Sprint_0_Warm_Up
{
    public abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }
        public bool IsFlying { get; set; }
        public int MaxAltitude { get; set; }

        Engine Engine { get; set; }

        bool EngineStart = false;


        public AerialVehicle()
        {

        }

        public string About()
        {


            if (IsFlying == true)
            {
                WriteLine("This OOPFlyingVehicle.Airplane has a max altitude of 41000ft.");
                WriteLine("It's current altitude is " + CurrentAltitude + " ft");
                return "OOPFlyingVehicleMidterm.Airplane engine is started";
            }
            else
            {
                WriteLine("This OOPFlyingVehicle.Airplane has a max altitude of 41000ft.");
                WriteLine("It's current altitude is " + CurrentAltitude + " ft");
                IsFlying = true;
                return "OOPFlyingVehicleMidterm.Airplane engine is not started";


            }


        }

        public string TakeOff()
        {

            if (EngineStart == false)
            {
                EngineStart = true;
                return "OOPFlyingVehicleMidterm.Airplane can't fly it's engine is not started.";

            }
            else
            {
                IsFlying = true;
                return "OOPFlyingVehicleMidterm.Airplane is flying";

            }

        }

        public void StartEngine()
        {

        }


        public void FlyDown(int howMuch)
        {
            if (howMuch <= 41000)
            {

                CurrentAltitude = CurrentAltitude - howMuch;

            }

        }

        internal void FlyUp(int HowMuch)
        {

            if (HowMuch <= 41000)
            {

                CurrentAltitude = CurrentAltitude + HowMuch;

            }
            else
            {


            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    abstract class Vehicle
    {

        private double EngineVolume { get; }
        private string TransmissionType { get; }
        private ushort MaxSpeed { get; }

        public Vehicle(double engineVolume, string transmissionType, ushort maxSpeed)
        {
            EngineVolume = engineVolume;
            TransmissionType = transmissionType;
            MaxSpeed = maxSpeed;
        }


        public virtual void GetFullInfo()
        {
            Console.WriteLine("/nEngine Volume: " + EngineVolume + "/nTransmissionType: " + TransmissionType + "/nMax speed: " + MaxSpeed);
        }

    }
}

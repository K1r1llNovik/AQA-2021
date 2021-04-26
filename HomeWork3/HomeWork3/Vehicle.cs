using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    public abstract class Vehicle
    {

        public double EngineVolume { get; }
        public string TransmissionType { get; }
        public ushort MaxSpeed { get; }

        public Vehicle(double engineVolume, string transmissionType, ushort maxSpeed)
        {
            EngineVolume = engineVolume;
            TransmissionType = transmissionType;
            MaxSpeed = maxSpeed;
        }


        public virtual void GetFullInfo()
        {
            Console.WriteLine("Engine Volume: " + EngineVolume + "\nTransmission Type: " + TransmissionType + "\nMax speed: " + MaxSpeed);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    public class Car : Vehicle
    {
        public ushort CarryingCapacity { get; }

        public Car(double engineVolume, string transmissionType, ushort maxSpeed, ushort carryingCapacity) : base(engineVolume, transmissionType, maxSpeed)
        {
            CarryingCapacity = carryingCapacity;
        }

        public override void GetFullInfo()
        {
            base.GetFullInfo();
            Console.WriteLine("CarryingCapacity: " + CarryingCapacity);
        }




    }
}

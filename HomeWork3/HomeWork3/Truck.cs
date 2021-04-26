using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    class Truck : Vehicle
    {
        public ushort MaxLoadWeight { get; }

        public Truck(double engineVolume, string transmissionType, ushort maxSpeed, ushort maxLoadWeight) : base(engineVolume, transmissionType, maxSpeed)
        {
            MaxLoadWeight = maxLoadWeight;
        }

        public override void GetFullInfo()
        {
            base.GetFullInfo();
            Console.WriteLine("Max load weight: " + MaxLoadWeight);
        }
    }
}

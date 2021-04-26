using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    class Bus : Vehicle
    {
        public sbyte NumberOfPassengers { get; }

        public Bus(double engineVolume, string transmissionType, ushort maxSpeed, sbyte numberOfPassengers) : base (engineVolume, transmissionType, maxSpeed)
        {
            NumberOfPassengers = numberOfPassengers;
        }

        public override void GetFullInfo()
        {
            base.GetFullInfo();
            Console.WriteLine("Number of passengers: " + NumberOfPassengers);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    class Motorcycle : Vehicle
    {

        public sbyte NumberOfSeats { get; }

        public Motorcycle(double engineVolume, string transmissionType, ushort maxSpeed, sbyte numberOfSeats) : base (engineVolume, transmissionType, maxSpeed)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override void GetFullInfo()
        {
            base.GetFullInfo();
            Console.WriteLine("Number of seats: " + NumberOfSeats);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    class CarPark
    {
        private Vehicle[] vehicles;
        private int counter = 0;
        public ushort SizeOfPark { get; }

        public CarPark(ushort sizeOfPark)
        {
            SizeOfPark = sizeOfPark;
            vehicles = new Vehicle[SizeOfPark];
        }

        public void AddVehicleToPool(Vehicle vehicle)
        {
            if(counter < SizeOfPark)
            {
                vehicles[counter] = vehicle;
                counter++;
            }
            else
            {
                throw new ArgumentOutOfRangeException("CarPark is full");
            }
        }

        public void PrintInfoAboutCarPark()
        {
            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.GetFullInfo();
                Console.WriteLine();
            }
        }




    }
}

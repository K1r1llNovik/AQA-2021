using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle car = new Car(3.0, "auto", 215,2500);
            Vehicle bus = new Bus(8.0, "mechanic", 140, 36);
            Vehicle motocycle = new Motorcycle(1.5, "mechanic", 200, 2);

            CarPark Garage = new CarPark(3);
            Garage.AddVehicleToPool(car);
            Garage.AddVehicleToPool(bus);
            Garage.AddVehicleToPool(motocycle);

            Garage.PrintInfoAboutCarPark();

        }
    }
}

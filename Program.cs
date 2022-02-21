using System;
using System.Collections.Generic;

namespace AutonomousCars
{
    internal class Program
    {
        // Small program which tests the closest vehicle functionality.
        static void Main(string[] args)
        {
            IVehicle car = new Vehicle(
                new VehicleInformation("0", VehicleType.Car, "Hyundai", "i30"));
            // Set car's position in the center of Sibiu.
            car.SetGPSData(new GPSData(45.790488, 24.148855, 415));
            car.SetCurrentSpeed(30);

            IVehicle truck = new Vehicle(
                new VehicleInformation("1", VehicleType.Truck, "MAN", "XLION"));
            // Set truck's position on a highway near New York City.
            truck.SetGPSData(new GPSData(40.673750, -74.173940, 10));
            truck.SetCurrentSpeed(110);

            IVehicle electricBike = new Vehicle(
                new VehicleInformation("1", VehicleType.ElectricBike, "KTM", "Prowler 292"));
            // Set bike's position on the same street as the car.
            electricBike.SetGPSData(new GPSData(45.792764, 24.145721, 415));
            electricBike.SetCurrentSpeed(15);

            // Get the closest vehicle to the bikem, it should print the manufacturer of the car.
            var closestVehicleToBike = electricBike.GetClosestVehicle(new List<IVehicle> { car, truck });
            Console.WriteLine(closestVehicleToBike.VehicleInformation.Manufacturer);
        }
    }
}

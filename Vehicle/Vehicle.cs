using System;
using System.Collections.Generic;

namespace AutonomousCars
{
    public class Vehicle : IVehicle
    {
        private IVehicleInformation _vehicleInformation;

        public Vehicle(IVehicleInformation vehicleInformation)
        {
            _vehicleInformation = vehicleInformation;
        }

        public IVehicleInformation VehicleInformation { get => _vehicleInformation; }

        public double CalculateDistance(IVehicle vehicle)
        {
            if (vehicle == null || vehicle.VehicleInformation.GPSData == null)
            {
                throw new ArgumentException("Invalid vehicle!");
            }

            // Calculate Euclid's distance to vehicle
            return Math.Sqrt(
                Math.Pow(_vehicleInformation.GPSData.Latitude - vehicle.VehicleInformation.GPSData.Latitude, 2) + 
                Math.Pow(_vehicleInformation.GPSData.Longitude - vehicle.VehicleInformation.GPSData.Longitude, 2) +
                Math.Pow(_vehicleInformation.GPSData.Altitude - vehicle.VehicleInformation.GPSData.Altitude, 2)
                );
        }

        public IVehicle GetClosestVehicle(ICollection<IVehicle> vehicles)
        {
            if (vehicles.Count == 0)
            {
                throw new ArgumentException("Empty vehicle collection!");
            }

            IVehicle closestVehicle = null;
            double closestDistance = double.MaxValue;

            foreach (IVehicle vehicle in vehicles)
            {
                if (vehicle == null)
                {
                    continue;
                }

                double distance = CalculateDistance(vehicle);
                if (distance <= closestDistance)
                {
                    closestDistance = distance;
                    closestVehicle = vehicle;
                }
            }

            return closestVehicle;
        }

        public IVehicleInformation ReceiveInformation(IVehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentException("Invalid vehicle!");
            }

            return vehicle.VehicleInformation;
        }

        public void SendInformationToOne(IVehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentException("Invalid vehicle!");
            }

            vehicle.ReceiveInformation(this);
        }

        public void SendInformationToMany(ICollection<IVehicle> vehicles)
        {
            if (vehicles.Count == 0)
            {
                throw new ArgumentException("Empty vehicle collection!");
            }

            foreach (IVehicle vehicle in vehicles)
            {
                if (vehicle == null)
                {
                    continue;
                }

                SendInformationToOne(vehicle);
            }
        }

        public void SetCurrentSpeed(double currentSpeed)
        {
            if (currentSpeed < 0)
            {
                throw new ArgumentException("Invalid speed value!");
            }

            _vehicleInformation.CurrentSpeed = currentSpeed;
        }

        public void SetGPSData(GPSData gpsData)
        {
            if (gpsData == null)
            {
                throw new ArgumentException("Invalid GPS data!");
            }

            _vehicleInformation.GPSData = gpsData;
        }

        public void AddVehicleEvent(IVehicleEvent vehicleEvent)
        {
            if (vehicleEvent == null)
            {
                throw new ArgumentException("Invalid Vehicle Event!");
            }

            _vehicleInformation.Events.Add(vehicleEvent);
        }
    }
}

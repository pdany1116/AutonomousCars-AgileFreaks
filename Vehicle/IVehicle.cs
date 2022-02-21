using System.Collections.Generic;

namespace AutonomousCars
{
    public interface IVehicle
    {
        IVehicleInformation VehicleInformation { get; }

        IVehicleInformation ReceiveInformation(IVehicle vehicle);

        void SendInformationToOne(IVehicle vehicle);

        void SendInformationToMany(ICollection<IVehicle> vehicles);

        void SetCurrentSpeed(double speed);

        void SetGPSData(GPSData gpsData);

        double CalculateDistance(IVehicle vehicle);

        IVehicle GetClosestVehicle(ICollection<IVehicle> vehicles);

        void AddVehicleEvent(IVehicleEvent vehicleEvent);
    }
}

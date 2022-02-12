using System.Collections.Generic;

namespace AutonomousCars
{
    public interface IVehicleInformation
    {
        string Id { get; }

        VehicleType VehicleType { get; }

        string Manufacturer { get; }

        string Model { get; }

        double CurrentSpeed { get; set; }

        GPSData GPSData { get; set; }

        ICollection<IVehicleEvent> Events { get; }
    }
}
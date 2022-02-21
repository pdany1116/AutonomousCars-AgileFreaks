using System.Collections.Generic;

namespace AutonomousCars
{
    public class VehicleInformation : IVehicleInformation
    {
        private string _id;
        private VehicleType _type;
        private string _manufacturer;
        private string _model;
        private double _currentSpeed;
        private GPSData _gpsData;
        private List<IVehicleEvent> _events;

        public VehicleInformation(string id, VehicleType type, string manufacturer, string model)
        {
            _id = id;
            _type = type;
            _manufacturer = manufacturer;
            _model = model;
            _currentSpeed = 0;
            _gpsData = null;
            _events = new List<IVehicleEvent>();
        }

        public string Id { get => _id; }

        public VehicleType VehicleType { get => _type; }

        public string Manufacturer { get => _manufacturer; }

        public string Model { get => _model; }

        public double CurrentSpeed { get => _currentSpeed; set => _currentSpeed = value; }

        public GPSData GPSData { get => _gpsData; set => _gpsData = value; }

        public ICollection<IVehicleEvent> Events { get => _events; }
    }
}


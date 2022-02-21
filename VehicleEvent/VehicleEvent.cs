namespace AutonomousCars
{
    public class VehicleEvent : IVehicleEvent
    {
        string _id;
        VehicleEventType _type;
        string _description;

        public VehicleEvent(string id, VehicleEventType type, string description)
        {
            _id = id;
            _type = type;
            _description = description;
        }

        public string Id { get => _id; }

        public VehicleEventType Type { get => _type; }

        public string Description { get => _description; }
    }
}

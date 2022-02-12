namespace AutonomousCars
{
    public interface IVehicleEvent
    {
        string Id { get; }

        VehicleEventType Type { get; }

        string Description { get; }
    }
}
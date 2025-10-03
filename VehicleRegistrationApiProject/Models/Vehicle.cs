namespace VehicleRegistrationApi.Models;

public enum VehicleState
{
    Available,
    Rented,
    Maintenance
}

public enum VehicleType
{
    Car,
    Truck,
    Motorcycle,
    Other
}

public class Vehicle
{
    // Plate used as unique identifier
    public string Plate { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public VehicleState State { get; set; }
    public VehicleType Type { get; set; }
}

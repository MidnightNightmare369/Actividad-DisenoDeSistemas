namespace VehicleRegistrationApi.DTOs;

using VehicleRegistrationApi.Models;

public class VehicleCreateDto
{
    public string Plate { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public VehicleState State { get; set; } = VehicleState.Available;
    public VehicleType Type { get; set; } = VehicleType.Car;
}

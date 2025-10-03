namespace VehicleRegistrationApi.DTOs;

using VehicleRegistrationApi.Models;

public class VehicleUpdateDto
{
    // Plate in URL path; do not allow changing plate here to keep identity stable
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public VehicleState State { get; set; } = VehicleState.Available;
    public VehicleType Type { get; set; } = VehicleType.Car;
}

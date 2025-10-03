using VehicleRegistrationApi.Models;

namespace VehicleRegistrationApi.Services;

public interface IVehicleService
{
    IEnumerable<Vehicle> GetAll();
    Vehicle? GetByPlate(string plate);
    bool Add(Vehicle vehicle, out string? errorMessage);
    bool Update(string plate, Vehicle vehicle, out string? errorMessage);
    bool Delete(string plate);
}

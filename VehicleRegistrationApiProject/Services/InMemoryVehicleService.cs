using System.Collections.Concurrent;
using VehicleRegistrationApi.Models;

namespace VehicleRegistrationApi.Services;

public class InMemoryVehicleService : IVehicleService
{
    private readonly ConcurrentDictionary<string, Vehicle> _vehicles = new(StringComparer.OrdinalIgnoreCase);

    public InMemoryVehicleService()
    {
        // Seed with one example vehicle
        var seed = new Vehicle
        {
            Plate = "ABC123",
            Make = "Toyota",
            Model = "Corolla",
            Year = 2020,
            State = VehicleState.Available,
            Type = VehicleType.Car
        };
        _vehicles[seed.Plate] = seed;
    }

    public IEnumerable<Vehicle> GetAll()
    {
        return _vehicles.Values.OrderBy(v => v.Plate);
    }

    public Vehicle? GetByPlate(string plate)
    {
        if (string.IsNullOrWhiteSpace(plate)) return null;
        _vehicles.TryGetValue(plate.Trim(), out var vehicle);
        return vehicle;
    }

    public bool Add(Vehicle vehicle, out string? errorMessage)
    {
        errorMessage = null;
        if (vehicle == null)
        {
            errorMessage = "Vehicle is null.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(vehicle.Plate))
        {
            errorMessage = "Plate is required.";
            return false;
        }

        vehicle.Plate = vehicle.Plate.Trim();

        var currentYear = DateTime.UtcNow.Year + 1;
        if (vehicle.Year < 1900 || vehicle.Year > currentYear)
        {
            errorMessage = $"Year must be between 1900 and {currentYear}.";
            return false;
        }

        // Try to add; if exists return error
        if (!_vehicles.TryAdd(vehicle.Plate, vehicle))
        {
            errorMessage = "A vehicle with the same plate already exists.";
            return false;
        }

        return true;
    }

    public bool Update(string plate, Vehicle vehicle, out string? errorMessage)
    {
        errorMessage = null;
        if (string.IsNullOrWhiteSpace(plate))
        {
            errorMessage = "Plate is required in path.";
            return false;
        }

        plate = plate.Trim();

        if (!_vehicles.ContainsKey(plate))
        {
            errorMessage = "Vehicle not found.";
            return false;
        }

        var currentYear = DateTime.UtcNow.Year + 1;
        if (vehicle.Year < 1900 || vehicle.Year > currentYear)
        {
            errorMessage = $"Year must be between 1900 and {currentYear}.";
            return false;
        }

        // Keep plate identity unchanged
        vehicle.Plate = plate;
        _vehicles[plate] = vehicle;
        return true;
    }

    public bool Delete(string plate)
    {
        if (string.IsNullOrWhiteSpace(plate)) return false;
        return _vehicles.TryRemove(plate.Trim(), out _);
    }
}

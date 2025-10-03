using Microsoft.AspNetCore.Mvc;
using VehicleRegistrationApi.DTOs;
using VehicleRegistrationApi.Models;
using VehicleRegistrationApi.Services;

namespace VehicleRegistrationApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController : ControllerBase
{
    private readonly IVehicleService _service;

    public VehiclesController(IVehicleService service)
    {
        _service = service;
    }

    /// <summary>
    /// Obtiene la lista de vehículos.
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<Vehicle>> GetAll()
    {
        return Ok(_service.GetAll());
    }

    /// <summary>
    /// Obtiene un vehículo por placa.
    /// </summary>
    [HttpGet("{plate}")]
    public ActionResult<Vehicle> GetByPlate(string plate)
    {
        var vehicle = _service.GetByPlate(plate);
        if (vehicle == null) return NotFound(new { message = "Vehículo no encontrado." });
        return Ok(vehicle);
    }

    /// <summary>
    /// Registra un nuevo vehículo.
    /// </summary>
    [HttpPost]
    public ActionResult Create([FromBody] VehicleCreateDto dto)
    {
        if (dto == null) return BadRequest(new { message = "Payload inválido." });

        var vehicle = new Vehicle
        {
            Plate = dto.Plate?.Trim() ?? string.Empty,
            Make = dto.Make,
            Model = dto.Model,
            Year = dto.Year,
            State = dto.State,
            Type = dto.Type
        };

        if (!_service.Add(vehicle, out var error))
        {
            return BadRequest(new { message = error });
        }

        // Return location of new resource
        return CreatedAtAction(nameof(GetByPlate), new { plate = vehicle.Plate }, vehicle);
    }

    /// <summary>
    /// Actualiza un vehículo existente (no permite cambiar la placa).
    /// </summary>
    [HttpPut("{plate}")]
    public ActionResult Update(string plate, [FromBody] VehicleUpdateDto dto)
    {
        var existing = _service.GetByPlate(plate);
        if (existing == null) return NotFound(new { message = "Vehículo no encontrado." });

        var updated = new Vehicle
        {
            Plate = existing.Plate, // keep same identity
            Make = dto.Make,
            Model = dto.Model,
            Year = dto.Year,
            State = dto.State,
            Type = dto.Type
        };

        if (!_service.Update(plate, updated, out var error))
        {
            return BadRequest(new { message = error });
        }

        return NoContent();
    }

    /// <summary>
    /// Elimina un vehículo por placa.
    /// </summary>
    [HttpDelete("{plate}")]
    public ActionResult Delete(string plate)
    {
        var existing = _service.GetByPlate(plate);
        if (existing == null) return NotFound(new { message = "Vehículo no encontrado." });

        var removed = _service.Delete(plate);
        if (!removed) return StatusCode(500, new { message = "No se pudo eliminar el vehículo." });

        return NoContent();
    }
}

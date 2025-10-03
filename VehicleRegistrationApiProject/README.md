# VehicleRegistrationApi (Prototipo)

Proyecto prototipo en **C# (.NET 8.0)** para un **sistema de registro de vehículos** (empresa de alquiler de vehículos).
Contiene endpoints básicos y documentación Swagger para probar el API.

## Requisitos
- .NET SDK 8.0 instalado.
- Visual Studio 2022 (con soporte .NET 8) o Visual Studio Code + C# extension.

## Ejecutar localmente (desde la carpeta del proyecto)
```bash
dotnet restore
dotnet run
```

Por defecto la aplicación ejecutará Kestrel y Swagger estará disponible en desarrollo en:
`https://localhost:5001/swagger/index.html`

## Endpoints principales
- `GET /api/vehicles` - listar vehículos
- `GET /api/vehicles/{plate}` - ver vehículo por placa
- `POST /api/vehicles` - crear vehículo
- `PUT /api/vehicles/{plate}` - actualizar vehículo (no cambia placa)
- `DELETE /api/vehicles/{plate}` - eliminar vehículo

## Ejemplo payload para POST /api/vehicles
```json
{
  "plate": "XYZ987",
  "make": "Nissan",
  "model": "Sentra",
  "year": 2022,
  "state": "Available",
  "type": "Car"
}
```

## Notas
- El servicio usa almacenamiento en memoria (`InMemoryVehicleService`) para mantener el prototipo simple.
- La validación incluye: placa única, año en rango razonable (1900 - año actual + 1).

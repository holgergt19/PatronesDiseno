using DesignPatterns.Models;
using System;

// Clase abstracta que actúa como base para los decoradores de vehículos
public abstract class VehicleDecorator : IVehicle
{
    private readonly IVehicle _vehicle;

    protected VehicleDecorator(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }

    // Implementación de las propiedades de IVehicle
    public Guid ID => _vehicle.ID;
    public int Tires
    {
        get => _vehicle.Tires;
        set => _vehicle.Tires = value;
    }
    public string Color
    {
        get => _vehicle.Color;
        set => _vehicle.Color = value;
    }
    public string Brand
    {
        get => _vehicle.Brand;
        set => _vehicle.Brand = value;
    }
    public string Model
    {
        get => _vehicle.Model;
        set => _vehicle.Model = value;
    }
    public double Gas
    {
        get => _vehicle.Gas;
        set => _vehicle.Gas = value;
    }
    public double FuelLimit
    {
        get => _vehicle.FuelLimit;
        set => _vehicle.FuelLimit = value;
    }

    // Implementación de los métodos de IVehicle
    public void StartEngine()
    {
        _vehicle.StartEngine();
    }

    public void StopEngine()
    {
        _vehicle.StopEngine();
    }

    public void AddGas()
    {
        _vehicle.AddGas();
    }

    public bool NeedsGas()
    {
        return _vehicle.NeedsGas();
    }

    public bool IsEngineOn()
    {
        return _vehicle.IsEngineOn();
    }

    // ... otras propiedades y métodos que se heredarán y se podrán modificar en los decoradores específicos
}

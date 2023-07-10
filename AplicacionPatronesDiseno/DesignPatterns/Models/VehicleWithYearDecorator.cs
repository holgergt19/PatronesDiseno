// Decorador con propiedades adicionales para Vehicle
using DesignPatterns.Models;
using System;

public class VehicleWithYearDecorator : VehicleDecorator
{
    public int Year { get; set; }

    public VehicleWithYearDecorator(IVehicle vehicle) : base(vehicle)
    {
    }

    public override string ToString()
    {
        // Agregar la propiedad Year al resultado de ToString() del decorador base
        return $"{base.ToString()}, Year: {Year}";
    }
}


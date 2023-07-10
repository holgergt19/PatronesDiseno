using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    // Patrón de diseño: Repositorio en memoria (In-Memory Repository)
    // Este patrón se utiliza para simular un repositorio de datos en memoria sin necesidad de una base de datos real.
    public class InMemoryVehicleRepository : IVehicleRepository
    {
        private readonly List<Vehicle> _vehicles;

        public InMemoryVehicleRepository()
        {
            _vehicles = new List<Vehicle>();
        }

        // Método para agregar un vehículo al repositorio
        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        // Método para buscar un vehículo por ID en el repositorio
        public Vehicle Find(string id)
        {
            return _vehicles.FirstOrDefault(v => v.ID.Equals(id));
        }

        // Método para obtener todos los vehículos del repositorio
        public List<Vehicle> GetVehicles()
        {
            return _vehicles;
        }
    }
}

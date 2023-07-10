using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    public class DBVehicleRepository : IVehicleRepository
    {
        private readonly List<Vehicle> _vehicles;

        public DBVehicleRepository()
        {
            _vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public Vehicle Find(string id)
        {
            return _vehicles.FirstOrDefault(v => v.ID.Equals(id));
        }

        public List<Vehicle> GetVehicles()
        {
            return _vehicles;
        }
    }
}

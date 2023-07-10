using System.Collections.Generic;
using DesignPatterns.Models;

namespace DesignPatterns.Repositories
{
    public interface IVehicleRepository
    {
        void AddVehicle(Vehicle vehicle);
        List<Vehicle> GetVehicles();
        Vehicle Find(string id);
    }
}

using DesignPatterns.Models;
using System.Collections.Generic;

namespace DesignPatterns.Repositories
{
    public class MyVehiclesRepository : IVehicleRepository
    {
        private static MyVehiclesRepository _instance;
        private readonly List<Vehicle> _vehicles;

        private MyVehiclesRepository()
        {
            _vehicles = new List<Vehicle>();
        }

        public static MyVehiclesRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MyVehiclesRepository();
            }
            return _instance;
        }


        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public List<Vehicle> GetVehicles()
        {
            return _vehicles;
        }

        public Vehicle Find(string id)
        {
            return _vehicles.Find(v => v.ID.Equals(id));
        }
    }
}

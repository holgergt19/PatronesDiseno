using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public interface IVehicle
    {

            Guid ID { get; }
            int Tires { get; set; }
            string Color { get; set; }
            string Brand { get; set; }
            string Model { get; set; }
            double Gas { get; set; }
            double FuelLimit { get; set; }

        void StartEngine();

        void StopEngine();

        void AddGas();

        bool NeedsGas();

        bool IsEngineOn();
    }
}

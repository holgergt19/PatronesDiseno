using DesignPatterns.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            // Crear un vehículo básico
            IVehicle vehicle = new Car("Ford", "Mustang", "Red");

            // Agregar propiedades adicionales utilizando los decoradores
            vehicle = new VehicleWithYearDecorator(vehicle)
            {
                Year = DateTime.Now.Year
            };

            // Utilizar el vehículo decorado con propiedades adicionales
            Console.WriteLine(vehicle.ToString());

            // Crear una instancia de la fábrica de vehículos de tipo CarFactory
            IVehicleFactory factory = new CarFactory();

            // Utilizar el Factory Method para crear una instancia de un vehículo
            IVehicle vehicle2 = factory.CreateVehicle();

            // Imprimir en la consola la información del vehículo creado
            Console.WriteLine($"Color: {vehicle.Color}, Marca: {vehicle.Brand}, Modelo: {vehicle.Model}, Neumáticos: {vehicle.Tires}");


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

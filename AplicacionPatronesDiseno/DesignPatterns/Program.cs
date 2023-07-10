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

            // Crear un veh�culo b�sico
            IVehicle vehicle = new Car("Ford", "Mustang", "Red");

            // Agregar propiedades adicionales utilizando los decoradores
            vehicle = new VehicleWithYearDecorator(vehicle)
            {
                Year = DateTime.Now.Year
            };

            // Utilizar el veh�culo decorado con propiedades adicionales
            Console.WriteLine(vehicle.ToString());

            // Crear una instancia de la f�brica de veh�culos de tipo CarFactory
            IVehicleFactory factory = new CarFactory();

            // Utilizar el Factory Method para crear una instancia de un veh�culo
            IVehicle vehicle2 = factory.CreateVehicle();

            // Imprimir en la consola la informaci�n del veh�culo creado
            Console.WriteLine($"Color: {vehicle.Color}, Marca: {vehicle.Brand}, Modelo: {vehicle.Model}, Neum�ticos: {vehicle.Tires}");


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

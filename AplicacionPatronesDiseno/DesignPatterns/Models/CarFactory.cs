// Paso 5: Implementa una clase CarFactory que implemente la interfaz IVehicleFactory y sea responsable de crear instancias de vehículos del tipo Car

using DesignPatterns.Models;

public class CarFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        // Puedes proporcionar los valores de color, marca y modelo de forma estática o solicitarlos como parámetros
        string color = "Red";
        string brand = "Ford";
        string model = "Escape";

        return new Car(color, brand, model);
    }
}

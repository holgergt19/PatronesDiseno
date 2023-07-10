// clase Car que herede de la clase Vehicle y ajuste sus propiedades específicas

using DesignPatterns.Models;

public class Car : Vehicle
{
    public override int Tires => 4;

    public Car(string color, string brand, string model) : base(color, brand, model)
    {

    }
}

namespace OOP.Polymorphism.Models
{
    public class Garage
    {
        public void Maintenance(Vehicle vehicle)
        {
            vehicle.StartEngine();
            vehicle.Drive();
            vehicle.Stop();
        }
    }
}

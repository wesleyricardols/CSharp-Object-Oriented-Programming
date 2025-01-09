namespace OOP.Polymorphism.Models
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public bool HasNavigationSystem { get; set; }

        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public override void Drive()
        {
            Console.WriteLine("Car is driving");
        }

        public override void Stop()
        {
            Console.WriteLine("Car stopped");
        }
    }
}

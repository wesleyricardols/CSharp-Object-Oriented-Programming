namespace OOP.Encapsulation.Models
{
    public class Car : Vehicle
    {
        public Car(string brand, string model, int year, int numberOfDoors, bool hasNavigationSystem)
            : base(brand, model, year)
        {
            NumberOfDoors = numberOfDoors;
            HasNavigationSystem = hasNavigationSystem;
            Console.WriteLine("Starting Vehicle Type Car");
        }

        private int NumberOfDoors { get; set; }
        private bool HasNavigationSystem { get; set; }

        public override void StartEngine()
        {
            NumberOfDoors = 123;

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

        public void Park()
        {
            Console.WriteLine("Car parked");
        }
    }
}

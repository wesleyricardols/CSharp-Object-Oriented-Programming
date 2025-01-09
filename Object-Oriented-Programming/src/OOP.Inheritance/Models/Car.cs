namespace OOP.Inheritance.Models
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

        public void Park()
        {
            Console.WriteLine("Car parked");
        }
    }
}

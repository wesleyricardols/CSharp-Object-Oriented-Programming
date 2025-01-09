namespace OOP.Encapsulation.Models
{
    public class Helicopter : Vehicle
    {
        public Helicopter(string brand, string model, int year, int numberOfRotorBlades, bool hasHoverMode)
            : base(brand, model, year)
        {
            NumberOfRotorBlades = numberOfRotorBlades;
            HasHoverMode = hasHoverMode;
            Console.WriteLine("Starting Vehicle Type Helicopter");
        }

        public int NumberOfRotorBlades { get; set; }
        public bool HasHoverMode { get; set; }

        public override void StartEngine()
        {
            Console.WriteLine("Helicopter engine started");
        }

        public override void Drive()
        {
            Console.WriteLine("Helicopter is flying");
        }


        public override void Stop()
        {
            Console.WriteLine("Helicopter is stopped");
        }

        public void ChangeAltitude(int feet)
        {
            Console.WriteLine($"Helicopter changed altitude to {feet} feet");
        }
    }
}

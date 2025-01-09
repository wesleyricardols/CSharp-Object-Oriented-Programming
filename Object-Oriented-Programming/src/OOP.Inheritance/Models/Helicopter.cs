namespace OOP.Inheritance.Models
{
    public class Helicopter : Vehicle
    {
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

        public void ChangeAltitude(int feet)
        {
            Console.WriteLine($"Helicopter changed altitude to {feet} feet");
        }
    }
}

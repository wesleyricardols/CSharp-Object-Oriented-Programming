namespace OOP.Polymorphism.Models
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

        public override void Stop()
        {
            Console.WriteLine("Helicopter stopped");
        }
    }

}

namespace OOP.Encapsulation.Models
{
    public class Airplane : Vehicle
    {
        public Airplane(string brand, string model, int year, int numberOfPassengers, int numberOfEngines)
            : base(brand, model, year)
        {
            NumberOfPassengers = numberOfPassengers;
            NumberOfEngines = numberOfEngines;
            Console.WriteLine("Starting Vehicle Type Airplane");
        }

        private int NumberOfPassengers { get; set; }
        private int NumberOfEngines { get; set; }

        public override void StartEngine()
        {
            Console.WriteLine("Airplane engine started");
        }

        public override void Drive()
        {
            Console.WriteLine("Airplane is flying");
        }

        public override void Stop()
        {
            Console.WriteLine("Airplane is stopped");
        }

        public void TakeOff()
        {
            Console.WriteLine("Airplane took off");
        }

        public void Land()
        {
            Console.WriteLine("Airplane landed");
        }
    }
}

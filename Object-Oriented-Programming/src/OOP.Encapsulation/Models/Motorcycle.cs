namespace OOP.Encapsulation.Models
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, string model, int year, int cc, int numberOfGears)
            : base(brand, model, year)
        {
            CC = cc;
            NumberOfGears = numberOfGears;
            Console.WriteLine("Starting Vehicle Type Motorcycle");
        }

        private int CC { get; set; }
        private int NumberOfGears { get; set; }
        
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started");
        }

        public override void Drive()
        {
            Console.WriteLine("Motorcycle is driving");
        }


        public override void Stop()
        {
            Console.WriteLine("Motorcycle stopped");
        }

        public void ShiftGear(int gear)
        {
            Console.WriteLine($"Motorcycle shifted to gear {gear}");
        }
    }
}

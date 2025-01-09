namespace OOP.Inheritance.Models
{
    public class Motorcycle : Vehicle
    {
        public int CC { get; set; }
        public int NumberOfGears { get; set; }

        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started");
        }

        public override void Drive()
        {
            Console.WriteLine("Motorcycle is driving");
        }

        public void ShiftGear(int gear)
        {
            Console.WriteLine($"Motorcycle shifted to gear {gear}");
        }
    }
}

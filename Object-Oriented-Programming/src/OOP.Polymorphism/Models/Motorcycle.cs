namespace OOP.Polymorphism.Models
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

        public override void Stop()
        {
            Console.WriteLine("Motorcycle stopped");
        }
    }

}

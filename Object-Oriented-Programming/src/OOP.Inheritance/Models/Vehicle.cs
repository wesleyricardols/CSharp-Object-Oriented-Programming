namespace OOP.Inheritance.Models
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle engine started");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is driving");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }
    }
}

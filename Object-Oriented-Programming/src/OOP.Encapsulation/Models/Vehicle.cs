namespace OOP.Encapsulation.Models
{
    public abstract class Vehicle
    {
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        protected string Brand { get; private set; }
        protected string Model { get; private set; }
        protected int Year { get; private set; }


        public abstract void StartEngine();

        public abstract void Drive();

        public abstract void Stop();
    }
}

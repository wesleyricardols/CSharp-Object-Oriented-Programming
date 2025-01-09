using OOP.Inheritance.Models;

Console.WriteLine("Starting Vehicle Type Car");
var car = new Car
{
    Brand = "Hyundai",
    Model = "HB20",
    Year = 2022,
    NumberOfDoors = 4,
    HasNavigationSystem = true,
};
car.StartEngine();
car.Drive();
car.Park();

Console.WriteLine("-------------------------------------------\n");

Console.WriteLine("Starting Vehicle Type Motorcycle");
var motorcycle = new Motorcycle
{
    Brand = "Harley-Davidson",
    Model = "Street Glide",
    Year = 2021,
    CC = 1200,
    NumberOfGears = 6
};
motorcycle.StartEngine();
motorcycle.Drive();
motorcycle.ShiftGear(4);

Console.WriteLine("-------------------------------------------\n");

Console.WriteLine("Starting Vehicle Type Helicopter");
var helicopter = new Helicopter
{
    Brand = "Sikorsky",
    Model = "S-92",
    Year = 2020,
    NumberOfRotorBlades = 3,
    HasHoverMode = true
};
helicopter.StartEngine();
helicopter.Drive();
helicopter.ChangeAltitude(15000);

Console.ReadLine();
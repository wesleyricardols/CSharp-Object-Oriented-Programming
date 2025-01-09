using OOP.Polymorphism.Models;

Car car = new Car
{
    NumberOfDoors = 4,
    HasNavigationSystem = true
};

Motorcycle motorcycle = new Motorcycle
{
    CC = 1200,
    NumberOfGears = 6
};

Helicopter helicopter = new Helicopter
{
    NumberOfRotorBlades = 4,
    HasHoverMode = true
};

Garage garage = new Garage();

Console.WriteLine("Starting Vehicle Type Car");
garage.Maintenance(car);
Console.WriteLine("-------------------------------------------\n");

Console.WriteLine("Starting Vehicle Type Motorcycle");
garage.Maintenance(motorcycle);
Console.WriteLine("-------------------------------------------\n");


Console.WriteLine("Starting Vehicle Type Helicopter");
garage.Maintenance(helicopter);

Console.ReadLine();
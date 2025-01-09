using OOP.Polymorphism.Models;

var car = new Car
{
    NumberOfDoors = 4,
    HasNavigationSystem = true
};

var motorcycle = new Motorcycle
{
    CC = 1200,
    NumberOfGears = 6
};

var helicopter = new Helicopter
{
    NumberOfRotorBlades = 4,
    HasHoverMode = true
};

var airplane = new Airplane
{
    NumberOfPassengers = 500,
    NumberOfEngines = 4
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
Console.WriteLine("-------------------------------------------\n");

Console.WriteLine("Starting Vehicle Type Airplane");
garage.Maintenance(airplane);
Console.ReadLine();
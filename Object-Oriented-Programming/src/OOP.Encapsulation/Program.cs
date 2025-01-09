using OOP.Encapsulation.Models;

var car = new Car("Hyundai", "HB20", 2022, 4, true);
car.StartEngine();
car.Drive();
car.Park();
car.Stop();

Console.WriteLine("-------------------------------------------\n");

var motorcycle = new Motorcycle("Harley-Davidson", "Street Glide", 2021, 1200, 6);
motorcycle.StartEngine();
motorcycle.Drive();
motorcycle.Stop();
motorcycle.ShiftGear(4);

Console.WriteLine("-------------------------------------------\n");

var helicopter = new Helicopter("Sikorsky", "S-92", 2020, 3, true);
helicopter.StartEngine();
helicopter.Drive();
helicopter.Stop();
helicopter.ChangeAltitude(15000);

Console.ReadLine();
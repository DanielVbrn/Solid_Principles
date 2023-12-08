using liskov.models;

IMotorizedVehicle car = new Car();
IVehicle bicycle = new Bicycle();

car.StartEngine();
car.Accelerate();

Console.WriteLine();

bicycle.Accelerate();

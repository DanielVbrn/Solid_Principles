namespace liskov.models
{
    public class Car : IMotorizedVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void Accelerate()
        {
            Console.WriteLine("Car accelerating");
        }
    }
}
namespace liskov.models
{
    public class Bicycle : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Bicycle pedaling");
        }
    }
}
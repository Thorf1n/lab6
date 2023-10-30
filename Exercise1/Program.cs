namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bus bus = new Bus();
            Train train = new Train();
            Human human = new Human();

            TransportNetwork network = new TransportNetwork();
            network.AddVehicle(car);
            network.AddVehicle(bus);
            network.AddVehicle(train);
            network.AddVehicle(human);

            network.MoveVehicles();

            Route route = new Route
            {
                StartPoint = "A",
                EndPoint = "B"
            };

            string optimalRoute = network.CalculateOptimalRoute(route, car);
            Console.WriteLine(optimalRoute);

            network.PassengerHandling(bus, 23);
        }
    }
}
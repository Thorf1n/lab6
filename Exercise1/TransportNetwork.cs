namespace Exercise1
{
    internal class TransportNetwork
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void MoveVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }

        public string CalculateOptimalRoute(Route route, Vehicle vehicle)
        {
            return $"Optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}";
        }

        public void PassengerHandling(Vehicle vehicle, int numberOfPassengers)
        {
            Console.WriteLine($"{numberOfPassengers} passengers are getting on  {vehicle.GetType().Name}");
        }
    }
}
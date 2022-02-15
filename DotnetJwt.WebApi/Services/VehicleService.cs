public class VehicleService : IVehicleService
{
    public IList<Vehicle> List()
    {
        return new List<Vehicle>() {
            new Vehicle() { Id = Guid.NewGuid().ToString(), Name = "BMW" }
        };
    }
}
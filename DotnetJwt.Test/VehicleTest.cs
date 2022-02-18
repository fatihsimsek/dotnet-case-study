using Xunit;
using System.Collections.Generic;

namespace DotnetJwt.Test;

public class VehicleTest
{
    [Fact]
    public void Vehicle_List_Test()
    {
        IVehicleService service = new VehicleService();
        IList<Vehicle> vehicles = service.List();
        Assert.Equal(vehicles.Count, 1);
    }
}
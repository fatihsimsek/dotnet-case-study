using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/vehicle/")]
[Authorize]
public class VehicleController : ControllerBase
{
    private readonly ILogger<VehicleController> logger;
    private readonly IVehicleService vehicleService;

    public VehicleController(IVehicleService vehicleService, 
                             ILogger<VehicleController> logger)
    {
        this.vehicleService = vehicleService;
        this.logger = logger;
    }

    [HttpGet("list")]
    public IActionResult List()
    {
        this.logger.LogDebug("UserId:" + this.User?.Identity?.Name);
        return Ok(this.vehicleService.List());
    }
}
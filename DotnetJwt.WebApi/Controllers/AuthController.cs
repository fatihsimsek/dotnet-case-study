using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/auth/")]
[AllowAnonymous]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> logger;
    private readonly IAuthencationService authencationService;
    
    public AuthController(IAuthencationService authencationService,
                          ILogger<AuthController> logger)
    {
        this.logger = logger;
        this.authencationService = authencationService;
    }

    [HttpPost("authenticate")]
    public IActionResult Authenticate(AuthenticateRequest request)
    {
        AuthenticateResponse response = authencationService.Authenticate(request);
        if(response == null) {
            return Unauthorized();
        }
        return Ok(response);
    }
}

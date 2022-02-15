using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class AuthenticationService : IAuthencationService
{
    private readonly IConfiguration configuration;
	public AuthenticationService(IConfiguration configuration)
	{
		this.configuration = configuration;
	}

    public AuthenticateResponse Authenticate(AuthenticateRequest request)
    {
        if (!request.Email.Equals("fatih.simsek@outlook.com") || !request.Password.Equals("12345")) {
			return null;
		}

		// Else we generate JSON Web Token
		var tokenHandler = new JwtSecurityTokenHandler();
		var tokenKey = Encoding.UTF8.GetBytes(this.configuration["JWT:Key"]);
		var tokenDescriptor = new SecurityTokenDescriptor
		{
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim("id", Guid.NewGuid().ToString()),
				new Claim(ClaimTypes.Name, request.Email),
                new Claim(ClaimTypes.Email, request.Email)                    
            }),
		    Expires = DateTime.UtcNow.AddMinutes(Convert.ToInt32(this.configuration["JWT:ExpireMinute"])),
		    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),SecurityAlgorithms.HmacSha256Signature)
		};
		var token = tokenHandler.CreateToken(tokenDescriptor);
		return new AuthenticateResponse { Token = tokenHandler.WriteToken(token) };
    }
}
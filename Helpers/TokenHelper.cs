using IdentityJWT.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IdentityJWT.Helpers
{
    public class TokenHelper
    {

        public static string GenerateToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("ci", user.CI),
                new Claim("role", user.Role)
                // Puedes agregar más claims aquí según tus necesidades
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("3hsfoUGKJAasdq9''/._asdq231^*52423n0sdfJLSIEFN39"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "Issuer",
                audience: "Audience",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(2), // Tiempo de expiración del token
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

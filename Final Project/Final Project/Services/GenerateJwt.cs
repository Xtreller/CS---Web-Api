using JsonWebToken;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Services
{
    public class GenerateJwt
    {
        private UserService _userService;

        public GenerateJwt(UserService userService)
        {
            _userService = userService;
        }
        public static string Generate(string userId)
        {


            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(userId));
            var credentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            // Creates a JWS descriptor with all its properties
            var claims = new[] {
                new Claim("id",userId),
            };
            var token = new JwtSecurityToken("Detailing Diary", "https://localhost:5001",
                claims,
                DateTime.UtcNow,
                expires: DateTime.Now.AddDays(1),
                signingCredentials:credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

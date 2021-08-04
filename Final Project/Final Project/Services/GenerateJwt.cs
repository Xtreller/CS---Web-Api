using Final_Project.Models;
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
        private const string KEY = "YVY63ARFNRIZOS0P85VSO262KC7CYYKSFB5MXBQHBBH7Z2J2XOMT3DXMRNB217TV07751NN2DGBUA3VEATZBHNF9IDH2QDRBL3HO6K2TGFCVVNWTKSKCQDP2YVDKTW2OYV4ZC1N4SZTM";
        public static readonly SymmetricSecurityKey signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));


        private UserService _userService;

        public GenerateJwt(UserService userService)
        {
            _userService = userService;
        }
    
        public static string GenerateJwtToken(ApplicationUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            //var credentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            var key = Encoding.UTF8.GetBytes(KEY);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Audience = "https://localhost:5001",
                Issuer = "https://localhost:5001",
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Id", user.Id),
                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;
        }
        public static string DecodeJwt(string token) {

            var handler = new JwtSecurityTokenHandler();
            var decodedToken = handler.ReadJwtToken(token);
            return decodedToken.ToString();
        }
    }
}

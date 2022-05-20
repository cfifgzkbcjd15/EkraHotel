using EkraHotel.Auth;
using EkraHotel.Data;
using EkraHotel.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace EkraHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private ApplicationContext db { get; set; }
        public AuthController(ApplicationContext _db)
        {
            db = _db;
        }
        [Route("Admin")]
        [HttpPost]
        public async Task<AuthModel> Auth(Login model)
        {
            var identity = db.Staffs.Include(x=>x.Roles).FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
            //var identity = GetIdentity(username, password);
            if (identity == null)
            {
                return null;
            }

            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,identity.Id.ToString() ),
                    new Claim(ClaimTypes.Role,identity.Roles.Name),
                    new Claim(ClaimTypes.Email,identity.Email)
                };
            ClaimsIdentity claimsIdentity =
            new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new AuthModel
            {
                Token = encodedJwt,
                FullName = identity.FullName
            };
            return response;
        }


        [Route("User")]
        [HttpPost]
        public async Task<AuthModel> AuthUser(Login model)
        {
            var identity = db.Customers.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
            //var identity = GetIdentity(username, password);
            if (identity == null)
            {
                return null;
            }

            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, identity.FullName),
                    new Claim(ClaimTypes.NameIdentifier,identity.Id.ToString()),
                    new Claim(ClaimTypes.Email,identity.Email)
                };
            ClaimsIdentity claimsIdentity =
            new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new AuthModel
            {
                Token = encodedJwt,
                FullName = identity.FullName
            };
            return response;
        }
    }

}

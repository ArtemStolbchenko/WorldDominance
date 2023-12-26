using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using WorldDomination.Databases;
using WorldDomination.Helpers;
using WorldDomination.Models;

namespace WorldDomination.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly ILogger<CodeController> _logger;
        private readonly IConfiguration _config;
        public AdminController(ILogger<CodeController> logger, AppDbContext dbContext, IConfiguration config)
        {
            _logger = logger;
            _appDbContext = dbContext;
            _config = config;
        }
        [HttpPost]
        public IActionResult Login([FromBody] string password)
        {

            if (password == _config["Admin:Password"])
            {

                //If login usrename and password are correct then proceed to generate token

                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSettings:SecretKey"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var Sectoken = new JwtSecurityToken(_config["JwtSettings:Issuer"],
                  _config["JwtSettings:Issuer"],
                  null,
                  expires: DateTime.Now.AddMinutes(120),
                  signingCredentials: credentials);

                var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);

                return Ok(token);
            }
            else return BadRequest("Wrong password, gtfo!");
        }

        [HttpGet]
        [Authorize]
        public IActionResult TestAuth()
        {
            return Ok("перемога");
        }
    }
}

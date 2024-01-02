using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using WorldDomination.Databases;
using WorldDomination.Helpers;
using WorldDomination.Models;

namespace WorldDomination.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeController : ControllerBase
    {
        private readonly CodeManager _manager;
        private readonly CodeDbContext _codeDbContext;
        private readonly ILogger<CodeController> _logger;

        public CodeController(ILogger<CodeController> logger, CodeDbContext dbContext)
        {
            _logger = logger;
            _codeDbContext = dbContext;
            _manager = new CodeManager(dbContext);
        }

        [HttpGet]
        [Route("Test")]
        public ActionResult<string> Get()
        {
            return Ok("ahahahhahah sasi))))");
        }
        [HttpPost]
        [Route("/Generate")]
        public ActionResult<string> GenerateCode()
        {
            return Ok(_manager.GetCode());
        }
        [HttpGet]
        [Route("/Check")]
        public ActionResult<string> CheckCode(string code)
        {
            bool result = _manager.Verify(code);
            if (result) return Ok("Welcome :)");
            else return base.Unauthorized();
        }
        [HttpGet]
        [Route("/GetAll")]
        public ActionResult<List<string>> GetAll()
        {
            return Ok(_codeDbContext.CodesString);
        }
    }
}
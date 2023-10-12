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
        private readonly AppDbContext _appDbContext;
        private readonly ILogger<CodeController> _logger;

        public CodeController(ILogger<CodeController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _manager = new CodeManager(dbContext);
        }

        [HttpGet]
        [Route("Test")]
        public ActionResult<string> Get()
        {
            return Ok("ahahahhahah sasi))))");
        }

        [HttpGet]
        [Route("Ahahahaha")]
        public ActionResult<string> Ahahahaha()
        {
            Code ogcode = new Code("I'm a code! Yay!");
            _appDbContext.Add(ogcode);
            _appDbContext.SaveChanges();
            return Ok(ogcode);
        }

        [HttpPost]
        [Route("/AddCustom")]
        public ActionResult<string> AddCustom(string code)
        {
            Code ogcode = new Code(code);
            _appDbContext.Add(ogcode);
            _appDbContext.SaveChanges(); 
            return Ok(ogcode);
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
            else return NotFound();
            //return Ok(_manager.GetCode());
        }
        [HttpGet]
        [Route("/GetAll")]
        public ActionResult<List<string>> GetAll()
        {
            return Ok(_appDbContext.CodesString);
            //return Ok(_manager.GetCode());
        }
    }
}
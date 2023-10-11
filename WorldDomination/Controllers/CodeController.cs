using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WorldDomination.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeController : ControllerBase
    {

        private readonly ILogger<CodeController> _logger;

        public CodeController(ILogger<CodeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Test")]
        public ActionResult<string> Get()
        {
            return Ok("ahahahhahah sasi))))");
        }

    }
}
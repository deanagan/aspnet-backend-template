using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly ILogger _logger;
        private string _name;

        public SampleController(ILogger<SampleController> logger)
        {
            this._logger = logger;
        }

        [HttpGet("[action]")]
        public IActionResult GetName()
        {
            return Ok(_name);
        }

        [HttpPost("[action]/{name}")]
        public IActionResult PostName(string name)
        {
            _name = name;
            return Ok();
        }

    }
}

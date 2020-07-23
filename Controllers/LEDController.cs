using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PiTopLightServer.Services;

namespace PiTopLightServer.Controllers
{
    [ApiController]
    public class LEDController : ControllerBase
    {
        private readonly ILogger<LEDController> _logger;
        private readonly LEDService _ledService;

        public LEDController(ILogger<LEDController> logger,
            LEDService ledService)
        {
            _logger = logger;
            _ledService = ledService;
        }

        [HttpGet]
        [Route("green")]
        public ActionResult Green()
        {
            _ledService.ToggleGreen();
            return Ok();
        }

        [HttpGet]
        [Route("red")]
        public ActionResult Red()
        {
            _ledService.ToggleRed();
            return Ok();
        }

        [HttpGet]
        [Route("amber")]
        public ActionResult Amber()
        {
            _ledService.ToggleGold();
            return Ok();
        }
    }
}

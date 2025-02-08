using Microsoft.AspNetCore.Mvc;
using System;

namespace FinalAssignment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetServerTime()
        {
            var serverTime = DateTime.Now;
            return Ok(new { serverTime });
        }
    }
}

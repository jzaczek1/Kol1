using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kol1.Controllers
{
    [Route("api/kolokwium")]
    [ApiController]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public IActionResult get()
        {
            return Ok("Działa");
        }
        [HttpGet("{id}")]
        public IActionResult getSth(int id)
        {
            return Ok(id);
        }
    }
}

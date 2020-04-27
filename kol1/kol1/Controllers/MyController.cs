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
            return Ok("Get działa");
        }

        [HttpGet("{id}")]
        public IActionResult getSth(int id)
        {
            return Ok("Get: " + id);
        }

        [HttpPost]
        public IActionResult post()
        {
            return Ok("Post działa");
        }

        [HttpPost("{id}/zmienna")]
        public IActionResult postSth(int id)
        {
            return Ok("Post: " + id);
        }
    }
}

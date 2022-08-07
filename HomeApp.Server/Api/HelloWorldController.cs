using HomeApp.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace HomeApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly AppDbContext ctx;

        public HelloWorldController(AppDbContext ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet("{text}")]
        public string HelloWorld([FromRoute] string? text)
        {
            return $"Hello world {text}! Time is: " + DateTime.Now;
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        public IActionResult Test()
        {
            return Ok(new { message = "Erorrl lkl k" });
        }
    }
}

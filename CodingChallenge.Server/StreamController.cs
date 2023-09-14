using Microsoft.AspNetCore.Mvc;

namespace CodingChallenge.Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}

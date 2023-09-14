using Microsoft.AspNetCore.Mvc;

namespace CodingChallenge.Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamController : ControllerBase
    {
        [HttpPost("FindSequence")]
        public OkObjectResult FindSequence([FromBody] FindSequenceRequest request)
        {
            return Ok(StreamService.FindLongestIncreasingSequence(request.stream));
        }
    }
}

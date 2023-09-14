using Microsoft.AspNetCore.Mvc;

namespace CodingChallenge.Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamController : ControllerBase
    {
        private readonly ILogger<StreamController> _logger;

        public StreamController(ILogger<StreamController> logger)
        {
            _logger = logger;
        }
        
        [HttpPost("FindSequence")]
        public OkObjectResult FindSequence([FromBody] FindSequenceRequest request)
        {
            _logger.LogInformation("Received request: {requestName} - ({@Command})", nameof(FindSequenceRequest), request);
            
            return Ok(StreamService.FindLongestIncreasingSequence(request.stream));
        }
    }
}

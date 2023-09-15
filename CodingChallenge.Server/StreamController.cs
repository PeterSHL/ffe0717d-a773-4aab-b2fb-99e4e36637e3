using Microsoft.AspNetCore.Mvc;

namespace CodingChallenge.Server;

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
    public IActionResult FindSequence([FromBody] FindSequenceRequest request)
    {
        _logger.LogInformation("Received request: {requestName} - ({@Command})", nameof(FindSequenceRequest), request);

        try
        {
            var result = StreamService.FindLongestIncreasingSequence(request.stream);

            _logger.LogInformation("Handled request: {requestName} - ({@Command})", nameof(FindSequenceRequest),
                request);

            return Ok(result);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error handling request: {requestName} - ({@Command})", nameof(FindSequenceRequest),
                request);

            return BadRequest();
        }
    }
}

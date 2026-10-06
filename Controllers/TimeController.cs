using Microsoft.AspNetCore.Mvc;

namespace FastdoSandbox.Controllers;

[ApiController]
[Route("api/time")]
public class TimeController : ControllerBase
{
    [HttpGet(Name = "GetServerTime")]
    public IActionResult Get()
    {
        return Ok(new
        {
            serverTime = DateTimeOffset.Now.ToString("o"),
            timeZone = TimeZoneInfo.Local.Id
        });
    }
}

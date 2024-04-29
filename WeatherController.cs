using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis;

[ApiController]
[Route("api/[controller]")]
public class WeatherController:Controller
{

    [HttpGet()]
    public string Today()
    {
        return DateTime.Now.ToString("dddd, dd MMMM yyyy");
    }
}

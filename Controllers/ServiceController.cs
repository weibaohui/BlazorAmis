using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/Mock/[controller]")]
public class ServiceController : Controller
{


    [HttpGet("Fail")]
    public object ServiceFail()
    {

        var data = new
        {
            status = 404,
            msg = "Not Found",
        };

        return data;
    }



}

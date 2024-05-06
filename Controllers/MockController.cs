using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/[controller]")]
public class MockController : Controller
{


    [HttpGet("Number/Random")]
    public object RandomNumber()
    {

        var data = new
        {
            status = 0,
            msg = "随机返回一个数字",
            data = new
            {
                random =Enumerable.Range(0,10).MinBy(x => Guid.NewGuid())
            }
        };

        return data;
    }



}

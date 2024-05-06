using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/Mock/[controller]")]
public class PageController
{
    [HttpGet("InitDataError")]
    public object InitDataError()
    {
        return new
        {
            status = 404,
            msg = "测试返回错误",
            msgTimeout = 10000,
            data = new
            {
                title = "Test Page Component",
                date = "2017-10-13"
            }
        };
    }

    [HttpGet("InitData")]
    public object InitData(string? keywords)
    {
        var data = new
        {
            status = 0,
            msg = "",
            data = new
            {
                title = "Test Page Component",
                date = "2017-10-13",
                keywords
            }
        };
        return data;
    }
}

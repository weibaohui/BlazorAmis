using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DataController:Controller
{

    [HttpGet("GetOptions")]
    public object GetOptions()
    {
        return new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                options = new[]
                {
                    new { label = "Option A", value = "a" },
                    new { label = "Option B", value = "b" },
                    new { label = "Option C", value = "c" },
                    new { label = "Option D", value = "d" },
                    new { label = "Option E", value = "e" },
                    new { label = "Option F", value = "f" },
                    new { label = "Option G", value = "g" },
                    new { label = "Option H", value = "h" },
                    new { label = "Option I", value = "i" },
                    new { label = "Option J", value = "j" },
                    new { label = "Option K", value = "k" },
                    new { label = "Option L", value = "l" },
                    new { label = "Option M", value = "m" },
                    new { label = "Option N", value = "n" },
                    new { label = "Option O", value = "o" },
                    new { label = "Option P", value = "p" },
                    new { label = "Option Q", value = "q" }
                }
            }
        };

    }
    [HttpGet("AutoComplete2")]
    public object AutoComplete2()
    {
        return new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                options = new[]
                {
                    new { label = "诸葛亮", value = "zhugeliang" },
                    new { label = "王昭君", value = "wangzhaojun" },
                    new { label = "露娜", value = "luna" },
                    new { label = "钟无艳", value = "zhongwuyan" },
                    new { label = "花木兰", value = "huamulan" }
                }
            }
        };

    }
    [HttpPost("SaveForm")]
    public object SaveForm()
    {
        return  new
        {
            status = 0,
            msg = "保存成功",
            data = new
            {
                id = 1
            }
        };


    }
}

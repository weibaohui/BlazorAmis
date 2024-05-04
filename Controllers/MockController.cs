using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/[controller]")]
public class MockController : Controller
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
        var waitSeconds = Request.Query["waitSeconds"];

        if (int.TryParse(waitSeconds, out var wait))
        {
            Thread.Sleep(wait * 1000);
        }

        return new
        {
            status = 0,
            msg = "保存成功",
            data = new
            {
                id = 1
            }
        };
    }

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


    [HttpGet("Form/InitData")]
    public object FormInitData()
    {
        var waitSeconds = Request.Query["waitSeconds"];

        if (int.TryParse(waitSeconds, out var wait))
        {
            Thread.Sleep(wait * 1000);
        }

        var q = Request.Query["keywords"];
        var info = string.IsNullOrWhiteSpace(q.FirstOrDefault()) ? "" : $"你输入的关键字是{q.FirstOrDefault()}";

        var tpl = Request.Query["tpl"].FirstOrDefault();
        var tplName = tpl switch
        {
            "tpl1" => "tpl1",
            "tpl2" => "tpl2",
            "tpl3" => "tpl3",
            _ => "Amis Renderer",
        };


        return new
        {
            status = 0,
            msg = "",
            msgTimeout = 10000,
            data = new
            {
                name = tplName,
                author = tplName,
                date = DateTimeOffset.Now.ToUnixTimeSeconds(),
                info = info
            }
        };
    }
}

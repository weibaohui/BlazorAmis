using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;


[ApiController]
[Route("Api/Mock/[controller]")]
public class FormController
{

    [HttpPost("SaveForm")]
    public object SaveForm(int? waitSeconds)
    {
        if (waitSeconds != null)
        {
            Thread.Sleep(waitSeconds.Value * 1000);
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

    [HttpPost("SaveFormFailed")]
    public object SaveFormFailed(int? waitSeconds)
    {
        if (waitSeconds != null)
        {
            Thread.Sleep(waitSeconds.Value * 1000);
        }


        return new
        {
            status = 422,
            msg = "",
            errors=new
            {
                test2="服务器端说，这个有错误。"
            }
        };
    }

    [Route("InitData")]
    public object FormInitData(int? waitSeconds,string? keywords,string? tpl)
    {

        if (waitSeconds != null)
        {
            Thread.Sleep(waitSeconds.Value * 1000);
        }
        var info = string.IsNullOrWhiteSpace(keywords) ? "" : $"你输入的关键字是{keywords}";

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

    [HttpGet("GetOptions")]
    public object GetOptions(int? waitSeconds)
    {
        if (waitSeconds != null)
        {
            Thread.Sleep(waitSeconds.Value * 1000);
        }
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

}

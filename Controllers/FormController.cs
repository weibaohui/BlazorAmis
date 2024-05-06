using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/Mock/[controller]")]
public class FormController
{
    [HttpGet("InitForm")]
    public object InitForm(int? waitSeconds)
    {
        if (waitSeconds != null)
        {
            Thread.Sleep(waitSeconds.Value * 1000);
        }


        var data = new
        {
            status = 0,
            msg = "",
            data = new
            {
                test1 = "xxxx@xxx.com",
                test2 = "",
                test3 = "bla bla",
                test4 =
                    "data:image/svg+xml,%3C%3Fxml version='1.0' standalone='no'%3F%3E%3C!DOCTYPE svg PUBLIC '-//W3C//DTD SVG 1.1//EN' 'http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd'%3E%3Csvg t='1631083237695' class='icon' viewBox='0 0 1024 1024' version='1.1' xmlns='http://www.w3.org/2000/svg' p-id='2420' xmlns:xlink='http://www.w3.org/1999/xlink' width='1024' height='1024'%3E%3Cdefs%3E%3Cstyle type='text/css'%3E%3C/style%3E%3C/defs%3E%3Cpath d='M959.872 128c0.032 0.032 0.096 0.064 0.128 0.128v767.776c-0.032 0.032-0.064 0.096-0.128 0.128H64.096c-0.032-0.032-0.096-0.064-0.128-0.128V128.128c0.032-0.032 0.064-0.096 0.128-0.128h895.776zM960 64H64C28.8 64 0 92.8 0 128v768c0 35.2 28.8 64 64 64h896c35.2 0 64-28.8 64-64V128c0-35.2-28.8-64-64-64z' p-id='2421' fill='%23bfbfbf'%3E%3C/path%3E%3Cpath d='M832 288c0 53.024-42.976 96-96 96s-96-42.976-96-96 42.976-96 96-96 96 42.976 96 96zM896 832H128V704l224-384 256 320h64l224-192z' p-id='2422' fill='%23bfbfbf'%3E%3C/path%3E%3C/svg%3E",
                test5 = new[]
                {
                    new
                    {
                        a =
                            "data:image/svg+xml,%3C%3Fxml version='1.0' standalone='no'%3F%3E%3C!DOCTYPE svg PUBLIC '-//W3C//DTD SVG 1.1//EN' 'http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd'%3E%3Csvg t='1631083237695' class='icon' viewBox='0 0 1024 1024' version='1.1' xmlns='http://www.w3.org/2000/svg' p-id='2420' xmlns:xlink='http://www.w3.org/1999/xlink' width='1024' height='1024'%3E%3Cdefs%3E%3Cstyle type='text/css'%3E%3C/style%3E%3C/defs%3E%3Cpath d='M959.872 128c0.032 0.032 0.096 0.064 0.128 0.128v767.776c-0.032 0.032-0.064 0.096-0.128 0.128H64.096c-0.032-0.032-0.096-0.064-0.128-0.128V128.128c0.032-0.032 0.064-0.096 0.128-0.128h895.776zM960 64H64C28.8 64 0 92.8 0 128v768c0 35.2 28.8 64 64 64h896c35.2 0 64-28.8 64-64V128c0-35.2-28.8-64-64-64z' p-id='2421' fill='%23bfbfbf'%3E%3C/path%3E%3Cpath d='M832 288c0 53.024-42.976 96-96 96s-96-42.976-96-96 42.976-96 96-96 96 42.976 96 96zM896 832H128V704l224-384 256 320h64l224-192z' p-id='2422' fill='%23bfbfbf'%3E%3C/path%3E%3C/svg%3E",
                        b = "xxxx", c = "xxxx@xxx.com"
                    }
                },
                test6 = new
                {
                    a =
                        "data:image/svg+xml,%3C%3Fxml version='1.0' standalone='no'%3F%3E%3C!DOCTYPE svg PUBLIC '-//W3C//DTD SVG 1.1//EN' 'http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd'%3E%3Csvg t='1631083237695' class='icon' viewBox='0 0 1024 1024' version='1.1' xmlns='http://www.w3.org/2000/svg' p-id='2420' xmlns:xlink='http://www.w3.org/1999/xlink' width='1024' height='1024'%3E%3Cdefs%3E%3Cstyle type='text/css'%3E%3C/style%3E%3C/defs%3E%3Cpath d='M959.872 128c0.032 0.032 0.096 0.064 0.128 0.128v767.776c-0.032 0.032-0.064 0.096-0.128 0.128H64.096c-0.032-0.032-0.096-0.064-0.128-0.128V128.128c0.032-0.032 0.064-0.096 0.128-0.128h895.776zM960 64H64C28.8 64 0 92.8 0 128v768c0 35.2 28.8 64 64 64h896c35.2 0 64-28.8 64-64V128c0-35.2-28.8-64-64-64z' p-id='2421' fill='%23bfbfbf'%3E%3C/path%3E%3Cpath d='M832 288c0 53.024-42.976 96-96 96s-96-42.976-96-96 42.976-96 96-96 96 42.976 96 96zM896 832H128V704l224-384 256 320h64l224-192z' p-id='2422' fill='%23bfbfbf'%3E%3C/path%3E%3C/svg%3E",
                    b = "xxxx", c = "xxxx@xxx.com"
                },
                localOptions = new object[]
                {
                    new { label = "选项1", value = "1" },
                    new
                    {
                        label = "选项2", value = "2",
                        children = new[] { new { label = "选项a", value = "a" }, new { label = "选项b", value = "b" } }
                    },
                    new { label = "选项3", value = "3" }
                }
            }
        };
        return data;
    }

    [HttpGet("GetTreeOptions")]
    public object GetTreeOptions(int? waitSeconds)
    {
        if (waitSeconds != null)
        {
            Thread.Sleep(waitSeconds.Value * 1000);
        }


        var data = new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                options = new object[]
                {
                    new
                    {
                        label = "Option A",
                        value = "a",
                        children = new[]
                        {
                            new { label = "Option X", value = "x" },
                            new { label = "Option Y", value = "y" },
                            new { label = "Option Z", value = "z" }
                        }
                    },
                    new
                    {
                        label = "Option B",
                        value = "b",
                        collapsed = true,
                        children = new[]
                        {
                            new { label = "Option 1", value = "1" },
                            new { label = "Option 2", value = "2" },
                            new { label = "Option 3", value = "3" }
                        }
                    },
                    new { label = "Option C", value = "c" },
                    new { label = "Option D", value = "d" },
                    new { label = "Option E", value = "e" }
                }
            }
        };
        return data;
    }
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

    [HttpGet("DeferOptions")]
    public object DeferOptions(int? waitSeconds, string? label = "lazy-option")
    {
        if (waitSeconds != null)
        {
            Thread.Sleep(waitSeconds.Value * 1000);
        }


        var data = new
        {
            status = 0,
            msg = "",
            data = new
            {
                options = new[]
                {
                    new { label = $"{label}-1", value = $"{label}-1", defer = true },
                    new { label = $"{label}-2", value = $"{label}-2", defer = true },
                    new { label = $"{label}-3", value = $"{label}-3", defer = false },
                    new { label = $"{label}-4", value = $"{label}-4", defer = false },
                    new { label = $"{label}-5", value = $"{label}-5", defer = false }
                }
            }
        };

        return data;
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
            errors = new
            {
                test2 = "服务器端说，这个有错误。"
            }
        };
    }

    [Route("InitData")]
    public object FormInitData(int? waitSeconds, string? keywords, string? tpl)
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

using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/Mock/[controller]")]
public class CrudController
{
    [HttpGet("Dynamic")]
    public object Dynamic(int? waitSeconds)
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
                count = 57,
                rows = new[]
                {
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 4.0",
                        platform = "Win 95+",
                        version = "4",
                        grade = "X",
                        id = 1
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 5.0",
                        platform = "Win 95+",
                        version = "5",
                        grade = "C",
                        id = 2
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 5.5",
                        platform = "Win 95+",
                        version = "5.5",
                        grade = "A",
                        id = 3
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 6",
                        platform = "Win 98+",
                        version = "6",
                        grade = "A",
                        id = 4
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 7",
                        platform = "Win XP SP2+",
                        version = "7",
                        grade = "A",
                        id = 5
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "AOL browser (AOL desktop)",
                        platform = "Win XP",
                        version = "6",
                        grade = "A",
                        id = 6
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 1.0",
                        platform = "Win 98+ / OSX.2+",
                        version = "1.7",
                        grade = "A",
                        id = 7
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 1.5",
                        platform = "Win 98+ / OSX.2+",
                        version = "1.8",
                        grade = "A",
                        id = 8
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 2.0",
                        platform = "Win 98+ / OSX.2+",
                        version = "1.8",
                        grade = "A",
                        id = 9
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 3.0",
                        platform = "Win 2k+ / OSX.3+",
                        version = "1.9",
                        grade = "A",
                        id = 10
                    }
                },
                columns = new[]
                {
                    new
                    {
                        label = "ID",
                        name = "id"
                    },
                    new
                    {
                        label = "引擎",
                        name = "engine"
                    },
                    new
                    {
                        label = "浏览器",
                        name = "browser"
                    },
                    new
                    {
                        label = "平台",
                        name = "platform"
                    }
                }
            }
        };
        return data;
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

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

    [Route("Sample/{id?}")]
    public object PostSampleWithId(string? id)
    {
        var waitSeconds = Request.Query["waitSeconds"];

        if (int.TryParse(waitSeconds, out var wait))
        {
            Thread.Sleep(wait * 1000);
        }

        var data = new
        {
            status = 0,
            data = new
            {
                engine = "Trident - cqngds",
                browser = "Internet Explorer 5.5",
                platform = "Win 95+",
                version = "5.5",
                grade = "A",
                id = id
            }
        };

        return data;
    }

    [HttpPost("Sample/BulkUpdate")]
    public object PostSampleBulkUpdate([FromBody] object input)
    {
        var waitSeconds = Request.Query["waitSeconds"];

        if (int.TryParse(waitSeconds, out var wait))
        {
            Thread.Sleep(wait * 1000);
        }

        var data = new
        {
            status = 0,
            msg = "保存成功！",
            data = input
        };

        return data;
    }

    [HttpPost("Sample/SaveOrder")]
    public object PostSampleSaveOrder([FromBody] object input)
    {
        var data = new
        {
            status = 0,
            msg = "保存成功！",
            data = input
        };

        return data;
    }

    [HttpPost("Sample/Add")]
    public object PostSampleAdd([FromBody] object input)
    {
        var data = new
        {
            status = 0,
            msg = "保存成功！",
            id = 1,
            data = input
        };

        return data;
    }

    [HttpGet("Sample")]
    public object Sample()
    {
        var waitSeconds = Request.Query["waitSeconds"];

        if (int.TryParse(waitSeconds, out var wait))
        {
            Thread.Sleep(wait * 1000);
        }

        var page = Request.Query["page"].FirstOrDefault() ?? "1";
        var perPageStr = Request.Query["perPage"].FirstOrDefault() ?? "15";
        var perPage = int.Parse(perPageStr);

        var numbers = Enumerable.Range(1, 1024);

        var data = new Data()
        {
            count = 1024,
            rows = new List<Row>(),
        };
        var root = new Root()
        {
            msg = "ok",
            status = 0,
            data = data
        };

        var engines = new string[] { "Gecko", "Presto", "Webkit", "Tasman", "Misc", "KHTML", "Trident" };
        var browsers = new string[]
        {
            "Netscape 7.2", "Camino 1.5", "Camino 1.0", "Internet Explorer 5.5", "Internet Explorer 4.0", "All others",
            "PSP browser", "IE Mobile", "Lynx", "Links", "Dillo 0.8", "NetFront 3.4", "NetFront 3.1",
            "Netscape Navigator 9", "Konqureror 3.5", "Nokia N800", "Internet Explorer 7", "AOL browser (AOL desktop)",
            "Firefox 3.0", "Firefox 2.0",
        };
        var platforms = new string[]
        {
            "Win 95+", "Win 98+", "Win XP", "Windows Mobile 6", "Embedded devices", "KDE 3.5", "Mac OS 8-9",
            "Mac OS 7.6-9", "Nintendo DS", "KDE 3.1", "N800", "Wii", "OSX.2+", "OSX.3+", "OSX.8+", "S60", "N800",
            "Gnome"
        };
        var versions = new string[] { "1", "2", "1.2", "1.5", "2.5", "3.5", "4.7", "9.5", "-" };
        var grades = new string[] { "A", "B", "C", "X", "U", "-" };

        var loop = (perPage != 0) ? perPage : numbers.Count();
        // 使用 foreach 循环遍历数字序列
        for (var i = 1; i <= loop; i++)
        {
            var row = new Row()
            {
                id = i,
                browser = browsers.OrderBy(x => Guid.NewGuid()).First(),
                engine = engines.OrderBy(x => Guid.NewGuid()).First(),
                platform = platforms.OrderBy(x => Guid.NewGuid()).First(),
                grade = grades.OrderBy(x => Guid.NewGuid()).First(),
                version = versions.OrderBy(x => Guid.NewGuid()).First(),
            };
            data.rows.Add(row);
        }

        return root;
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

using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/Mock/[controller]")]
public class SampleController
{
    [Route("{id}")]
    public object PostSampleWithId(string? id, int? waitSeconds)
    {
        if (waitSeconds != null)
        {
            Thread.Sleep(waitSeconds.Value * 1000);
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

    [HttpPost("BulkUpdate")]
    public object PostSampleBulkUpdate([FromBody] object input, int? waitSeconds)
    {
        if (waitSeconds != null)
        {
            Thread.Sleep(waitSeconds.Value * 1000);
        }

        var data = new
        {
            status = 0,
            msg = "保存成功！",
            data = input
        };

        return data;
    }

    [HttpPost("SaveOrder")]
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

    [HttpPost("Add")]
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
    public object Sample(int? waitSeconds, int page = 1, int perPage = 15)
    {
        if (waitSeconds != null)
        {
            Thread.Sleep(waitSeconds.Value * 1000);
        }


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
        var statuses = new bool[] { true,false };

        var loop = perPage;
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
                status = statuses.OrderBy(x => Guid.NewGuid()).First(),
            };
            data.rows.Add(row);
        }

        return root;
    }
}

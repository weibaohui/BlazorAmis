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


    [HttpGet("Options/Level2")]
    public object OptionsLevel2(string a)
    {
        var para = $"{a}";
        var data = new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                options = new[]
                {
                    new { label = $"选项{para}_a", value = $"{para}_a" },
                    new { label = $"选项{para}_b", value = $"{para}_b" },
                    new { label = $"选项{para}_c", value = $"{para}_c" }
                }
            }
        };

        return data;
    }

    [HttpGet("Options/Level3")]
    public object OptionsLevel3(string b)
    {
        var para = $"{b}";
        var data = new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                options = new[]
                {
                    new { label = $"选项{para}_x", value = $"{para}_x" },
                    new { label = $"选项{para}_y", value = $"{para}_y" },
                    new { label = $"选项{para}_z", value = $"{para}_z" }
                }
            }
        };

        return data;
    }

    [HttpGet("Chart/Chart1")]
    public object Chart1()
    {
        var data = new
        {
            status = 0,
            msg = "ok",
            data =
                @"{        backgroundColor: new echarts.graphic.RadialGradient(0.8044967218070067,0.28304730696081815,0.4347751041852883, [{            offset: 0,            color: '#f7f8fa'        }, {            offset: 1,            color: '#cdd0d5'        }]),        title: {            text: '1990 与 2015 年各国家人均寿命与 GDP'        },        legend: {            right: 10,            data: ['1990', '2015']        },        xAxis: {            splitLine: {                lineStyle: {                    type: 'dashed'                }            }        },        yAxis: {            splitLine: {                lineStyle: {                    type: 'dashed'                }            },            scale: true        },        series: [{            name: '1990',            data: [[28604,77,17096869,'Australia',1990],[31163,77.4,27662440,'Canada',1990],[1516,68,1154605773,'China',1990],[13670,74.7,10582082,'Cuba',1990],[28599,75,4986705,'Finland',1990],[29476,77.1,56943299,'France',1990],[31476,75.4,78958237,'Germany',1990],[28666,78.1,254830,'Iceland',1990],[1777,57.7,870601776,'India',1990],[29550,79.1,122249285,'Japan',1990],[2076,67.9,20194354,'North Korea',1990],[12087,72,42972254,'South Korea',1990],[24021,75.4,3397534,'New Zealand',1990],[43296,76.8,4240375,'Norway',1990],[10088,70.8,38195258,'Poland',1990],[19349,69.6,147568552,'Russia',1990],[10670,67.3,53994605,'Turkey',1990],[26424,75.7,57110117,'United Kingdom',1990],[37062,75.4,252847810,'United States',1990]],            type: 'scatter',            symbolSize: function (data) {                return Math.sqrt(data[2]) / 5e2;            },            label: {                emphasis: {                    show: true,                    formatter: function (param) {                        return param.data[3];                    },                    position: 'top'                }            },            itemStyle: {                normal: {                    shadowBlur: 10,                    shadowColor: 'rgba(120, 36, 50, 0.5)',                    shadowOffsetY: 5,                    color: new echarts.graphic.RadialGradient(0.4, 0.3, 1, [{                        offset: 0,                        color: 'rgb(251, 118, 123)'                    }, {                        offset: 1,                        color: 'rgb(204, 46, 72)'                    }])                }            }        }, {            name: '2015',            data: [[44056,81.8,23968973,'Australia',2015],[43294,81.7,35939927,'Canada',2015],[13334,76.9,1376048943,'China',2015],[21291,78.5,11389562,'Cuba',2015],[38923,80.8,5503457,'Finland',2015],[37599,81.9,64395345,'France',2015],[44053,81.1,80688545,'Germany',2015],[42182,82.8,329425,'Iceland',2015],[5903,66.8,1311050527,'India',2015],[36162,83.5,126573481,'Japan',2015],[1390,71.4,25155317,'North Korea',2015],[34644,80.7,50293439,'South Korea',2015],[34186,80.6,4528526,'New Zealand',2015],[64304,81.6,5210967,'Norway',2015],[24787,77.3,38611794,'Poland',2015],[23038,73.13,143456918,'Russia',2015],[19360,76.5,78665830,'Turkey',2015],[38225,81.4,64715810,'United Kingdom',2015],[53354,79.1,321773631,'United States',2015]],            type: 'scatter',            symbolSize: function (data) {                return Math.sqrt(data[2]) / 5e2;            },            label: {                emphasis: {                    show: true,                    formatter: function (param) {                        return param.data[3];                    },                    position: 'top'                }            },            itemStyle: {                normal: {                    shadowBlur: 10,                    shadowColor: 'rgba(25, 100, 150, 0.5)',                    shadowOffsetY: 5,                    color: new echarts.graphic.RadialGradient(0.4, 0.3, 1, [{                        offset: 0,                        color: 'rgb(129, 227, 238)'                    }, {                        offset: 1,                        color: 'rgb(25, 183, 207)'                    }])                }            }        }]      }"
        };

        return data;
    }

    [HttpGet("Chart/Chart2")]
    public object Chart2()
    {
        var data = new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                title = new
                {
                    text = "一天用电量分布",
                    subtext = "纯属虚构"
                },
                tooltip = new
                {
                    trigger = "axis",
                    axisPointer = new
                    {
                        type = "cross"
                    }
                },
                toolbox = new
                {
                    show = true,
                    feature = new
                    {
                        saveAsImage = new { }
                    }
                },
                xAxis = new
                {
                    type = "category",
                    boundaryGap = false,
                    data = new[]
                    {
                        "00:00", "01:15", "02:30", "03:45", "05:00",
                        "06:15", "07:30", "08:45", "10:00", "11:15",
                        "12:30", "13:45", "15:00", "16:15", "17:30",
                        "18:45", "20:00", "21:15", "22:30", "23:45"
                    }
                },
                yAxis = new
                {
                    type = "value",
                    axisLabel = new
                    {
                        formatter = "{value} W"
                    },
                    axisPointer = new
                    {
                        snap = true
                    }
                },
                visualMap = new
                {
                    show = false,
                    dimension = 0,
                    pieces = new object[]
                    {
                        new { lte = 6, color = "green" },
                        new { gt = 6, lte = 8, color = "red" },
                        new { gt = 8, lte = 14, color = "green" },
                        new { gt = 14, lte = 17, color = "red" },
                        new { gt = 17, color = "green" }
                    }
                },
                series = new[]
                {
                    new
                    {
                        name = "用电量",
                        type = "line",
                        smooth = true,
                        data = new[]
                        {
                            157, 47, 163, 60, 19, 57, 121, 38, 43, 84,
                            19, 165, 178, 194, 141, 148, 187, 154, 64, 156,
                            157, 172, 145, 75
                        },
                        markArea = new
                        {
                            data = new object[]
                            {
                                new object[]
                                {
                                    new  { name = "早高峰", xAxis = "07:30" },
                                    new { xAxis = "10:00" },
                                },

                                new object[]
                                {
                                    new { name = "晚高峰", xAxis = "17:30" },
                                    new { xAxis = "21:15" }
                                },



                            }
                        }
                    }
                }
            }
        };
        return data;
    }
}

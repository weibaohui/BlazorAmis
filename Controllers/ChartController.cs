using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/Mock/[controller]")]
public class ChartController
{


    [HttpGet("Chart")]
    public object Chart()
    {
        var data = new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                title = new
                {
                    text = "销售情况"
                },
                tooltip = new { },
                legend = new
                {
                    data = new[] { "销量" }
                },
                xAxis = new
                {
                    data = new[] { "衬衫", "羊毛衫", "雪纺衫", "裤子", "高跟鞋", "袜子" }
                },
                yAxis = new { },
                series = new[]
                {
                    new
                    {
                        name = "销量",
                        type = "bar",
                        data = new[] { 43, 19, 24, 99, 36, 55 }
                    }
                }
            }
        };
        return data;
    }

    [HttpGet("Chart1")]
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

    [HttpGet("Chart2")]
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
                                    new { name = "早高峰", xAxis = "07:30" },
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

    [HttpGet("ChartData")]
    public object ChartData()
    {
        var rand = new Random();
        var randomNumbers = Enumerable.Range(50, 100)
            .OrderBy(x => rand.Next())
            .Take(10);
        var data = new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                line = randomNumbers
            }
        };

        return data;
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/Mock/[controller]")]
public class OptionsController
{
    [HttpGet("Matrix")]
    public object Matrix(int? waitSeconds)
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
                columns = new[]
                {
                    new { label = "Col A", col = "a" },
                    new { label = "Col B", col = "b" },
                    new { label = "Col C", col = "c" },
                    new { label = "Col D", col = "d" },
                    new { label = "Col E", col = "e" }
                },
                rows = new[]
                {
                    new { label = "Row 1", rol = 1 },
                    new { label = "Row 2", rol = 2 },
                    new { label = "Row 3", rol = 3 },
                    new { label = "Row 4", rol = 4 },
                    new { label = "Row 5", rol = 5 },
                    new { label = "Row 6", rol = 6 }
                }
            }
        };
        return data;
    }
[HttpGet("Tree")]
    public object Tree(int? waitSeconds)
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
                        label = "Folder A",
                        value = "a",
                        children = new[]
                        {
                            new { label = "Sub File A", value = "a-a" },
                            new { label = "Sub File B", value = "a-b" }
                        }
                    },
                    new
                    {
                        label = "Folder B",
                        value = "b",
                        children = new object[]
                        {
                            new { label = "Sub File A", value = "b-a" },
                            new
                            {
                                label = "Sub Folder B",
                                value = "b-b",
                                children = new[]
                                {
                                    new { label = "Sub File A", value = "b-b-a" },
                                    new { label = "Sub File B", value = "b-b-b" }
                                }
                            }
                        }
                    },
                    new { label = "File C", value = "c" },
                    new { label = "File D", value = "d" },
                    new { label = "File E", value = "e" }
                }
            }
        };

        return data;
    }

    [HttpGet("AutoComplete2")]
    public object AutoComplete2(string? term)
    {
        var dicts = new[]
        {
            new { label = "诸葛亮", value = "zhugeliang" },
            new { label = "王昭君", value = "wangzhaojun" },
            new { label = "露娜", value = "luna" },
            new { label = "钟馗", value = "zhongkui" },
            new { label = "钟无艳", value = "zhongwuyan" },
            new { label = "花木兰", value = "huamulan" }
        };
        var options = dicts;
        if (!string.IsNullOrWhiteSpace(term))
        {
            options = dicts.Where(x => x.value.Contains(term) || x.label.Contains(term)).ToArray();
        }

        return new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                options = options
            }
        };
    }

    [HttpGet("Level2")]
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

    [HttpGet("Level3")]
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

    [HttpGet("ChainedOptions")]
    public object ChainedOptions(int? waitSeconds, string? parentId, int? level = 0, int? maxLevel = 4)
    {
        var para = $"{level}";
        if (level == maxLevel)
        {
            var data = new
            {
                status = 0,
            };
            return data;
        }
        else
        {
            var data = new
            {
                status = 0,
                msg = "ok",
                data = new
                {
                    options = new[]
                    {
                        new { label = $"选项A_{para}", value = "a" },
                        new { label = $"选项B_{para}", value = "b" },
                        new { label = $"选项C_{para}", value = "c" }
                    }
                }
            };

            return data;
        }
    }
}

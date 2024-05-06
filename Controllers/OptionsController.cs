using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/Mock/[controller]")]
public class OptionsController
{
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
            options = dicts.Where(x => x.value.Contains(term)  || x.label.Contains(term)).ToArray();
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
}

using BlazorAmis.Service;
using BlazorApp.Service.AI;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
public class ConvertController(IOpenAiService OpenAiService) : Controller
{
    [HttpGet("ai")]
    public async Task<string> Ai()
    {
        return await OpenAiService.AIChat("你是谁");
    }

    [HttpGet("ai2")]
    public string Ai2()
    {
        return ProcessJson("json");
    }

    [HttpGet("Convert")]
    public async Task<string> Convert()
    {
        var currentDirectory = Environment.CurrentDirectory;
        // 指定文件夹路径
        var folderPath = Path.Combine("/Users/weibh/projects/csharp/tmp/source/amis/examples/components/EventAction");

        // 遍历文件夹中的所有后缀为.jsx的文件
        var jsxFiles = Directory.GetFiles(folderPath, "*.jsx", SearchOption.AllDirectories);

        foreach (var filePath in jsxFiles)
        {
            await ProcessFile(filePath, folderPath);
        }


        // 遍历当前目录下的所有子目录，处理子目录下的.jsx文件
        var subDirectories = Directory.GetDirectories(folderPath);

        foreach (var subDirectory in subDirectories)
        {
            var filesInSubDirectory = Directory.GetFiles(subDirectory, "*.jsx");

            foreach (var filePath in filesInSubDirectory)
            {
                await ProcessFile(filePath, folderPath);
            }
        }

        return "x";
    }

    private async Task ProcessFile(string filePath, string folderPath)
    {
        Console.WriteLine($"正在处理文件 {filePath}");

        // 读取文件内容
        var txt = ConvertService.ReadFile(filePath);

        var csharpAi = await OpenAiService.AIChat(@"请将下面的js 属性定义 转换为 C# 匿名类。
{{定义}}
要求：
1、请逐行转换，请不要遗漏细节。
2、匿名类名称定义为`data`,即使用var data = new XX的方式。
2.1、数组的元素转换后本来是new [],但请改为new object[]的样式。
3、请直接返回匿名类的定义字符串。不要用任何字符包裹，只返回匿名类的定义字符串自身。
4、请不要返回任何解释。
5、请不要返回任何注释，包括// 和 /**/
6、请不要省略任何一个细节。请确保全部进行转换。
"
            .Replace("{{定义}}", txt));

        // //转换为标准的json
        // var json = ConvertService.NormalizeJson(txt);
        // //将json转换为标准的匿名类的定义字符串
        // Console.WriteLine(json);
        // var csharp = ConvertService.Json2Anonymous(json);

        // 获取相对于给定目录的相对文件名
        var relativeFilePath = Path.GetRelativePath(folderPath, filePath);
        //按没有后缀的文件名作为blazor页面访问路径
        var blazorPageUrl = Path.GetFileNameWithoutExtension(relativeFilePath);
        var blazor = ConvertService.Anonymous2Blazor(csharpAi, blazorPageUrl);

        // 构造新文件路径，替换后缀为.razor
        var newFilePath = Path.ChangeExtension(filePath, ".razor");
        // 将新的文件内容保存到.blazor文件中
        await System.IO.File.WriteAllTextAsync(newFilePath, blazor);

        Console.WriteLine($"文件 {filePath} 已处理并保存为 {newFilePath}");
    }

    private string ProcessJson(string json)
    {
        // //将json转换为标准的匿名类的定义字符串
        var csharp = ConvertService.Json2Anonymous(json);
        return csharp;
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/Mock/[controller]")]
public class TaskController
{
    [HttpGet("")]
    public object Task()
    {
        // 任务状态：
        // 0: 初始状态，不可操作。
        // 1: 就绪，可操作状态。
        // 2: 进行中，还没有结束。
        // 3：有错误，不可重试。
        // 4: 已正常结束。
        // 5：有错误，且可以重试。
        var data = new
        {
            status = 0,
            data = new[]
            {
                new { label = "Hive 运算", key = "hive", status = Enumerable.Range(0,6).MinBy(x => Guid.NewGuid()) },
                new { label = "小流浪", key = "partial", status = Enumerable.Range(0,6).MinBy(x => Guid.NewGuid()) },
                new { label = "全量", key = "full", status = Enumerable.Range(0,6).MinBy(x => Guid.NewGuid()) }
            }
        };

        return data;
    }


}

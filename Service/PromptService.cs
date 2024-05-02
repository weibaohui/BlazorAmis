using BlazorApp.Service;
using BlazorApp.Service.AI;

namespace BlazorAmis.Service;

public class PromptService(IConfigService configService) : IPromptService
{
    public string GetPrompt(string key)
    {
        var prompt = configService.GetSection("Prompt")?.GetValue<string>(key);
        return prompt;
    }



}

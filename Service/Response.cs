using System.Text.Json.Serialization;

namespace BlazorAmis.Service;

public record Response
{
    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("model")]
    public string Model { get; set; }

    [JsonPropertyName("choices")]
    public List<ChoiceResponse> Choices { get; set; }

    [JsonPropertyName("created")]
    public int CreatedAt { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

public record ChoiceResponse
{
    [JsonPropertyName("delta")]
    public Delta Delta { get; set; }

    [JsonPropertyName("index")]
    public int? Index { get; set; }

    [JsonPropertyName("finish_reason")]
    public string FinishReason { get; set; }
}

public record Delta
{
    [JsonPropertyName("content")]
    public string Content { get; set; }

    [JsonPropertyName("role")]
    public string Role { get; set; }
}

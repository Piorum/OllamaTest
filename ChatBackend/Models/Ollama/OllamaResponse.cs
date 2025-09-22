using System.Text.Json.Serialization;

namespace ChatBackend.Models.Ollama;

public class OllamaResponse
{
    [JsonPropertyName("response")]
    public string? Response { get; set; }
    [JsonPropertyName("done")]
    public bool Done { get; set; }
}

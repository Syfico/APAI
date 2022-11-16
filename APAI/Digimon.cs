using System.Text.Json.Serialization;

public class Digimon
{
    [JsonPropertyName(":name")]
    public string Name { get; set; }

    [JsonPropertyName(":level")]
    public int level { get; set; }

    [JsonPropertyName("is_default")]
    public bool isDefault { get; set; }
}

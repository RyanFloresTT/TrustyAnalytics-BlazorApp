using System.Text.Json.Serialization;

namespace BlazorApp.Models
{
    public class GameResponse
    {
        [JsonPropertyName("$values")]
        public List<Game> Games { get; set; }
    }
}

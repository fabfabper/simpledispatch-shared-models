using System.Text.Json.Serialization;

namespace SimpleDispatch.SharedModels.Dtos
{
    public class Unit
    {
        [JsonPropertyName("id")]
        public required string Id { get; set; }

        [JsonPropertyName("status")]
        public required int Status { get; set; }

        [JsonPropertyName("position")]
        public Coordinate? Position { get; set; }

        [JsonPropertyName("type")]
        public required string Type { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace SimpleDispatch.SharedModels.Dtos
{
    public class Event
    {
        [JsonPropertyName("id")]
        public required int Id { get; set; }

        [JsonPropertyName("location")]
        public required string Location { get; set; }

        [JsonPropertyName("position")]
        public required Coordinate Position { get; set; }

        [JsonPropertyName("type")]
        public required string Type { get; set; }
    }
}
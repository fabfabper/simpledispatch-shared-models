using System.Text.Json.Serialization;

namespace SimpleDispatchSharedModels.Dtos
{
    public class Event
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("position")]
        public Coordinate Position { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
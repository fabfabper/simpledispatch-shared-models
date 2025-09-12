using System.Text.Json.Serialization;

namespace SimpleDispatchSharedModels.Dtos
{
    public class Unit
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("statusId")]
        public int StatusId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("position")]
        public Coordinate Position { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace SimpleDispatch.SharedModels.Dtos
{
    public class Coordinate
    {
        [JsonPropertyName("latitude")]
        public required double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public required double Longitude { get; set; }
    }
}
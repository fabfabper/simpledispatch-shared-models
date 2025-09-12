using System.Text.Json.Serialization;

namespace SimpleDispatchSharedModels.Dtos
{
    public class Coordinate
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }
}
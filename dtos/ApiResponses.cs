using System.Text.Json.Serialization;

namespace SimpleDispatch.SharedModels.Dtos
{
    /// <summary>
    /// API response for Event data
    /// </summary>
    public class EventApiResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public Event? Data { get; set; }

        [JsonPropertyName("error")]
        public string? Error { get; set; }
    }

    /// <summary>
    /// API response for Unit data
    /// </summary>
    public class UnitApiResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public Unit? Data { get; set; }

        [JsonPropertyName("error")]
        public string? Error { get; set; }
    }
}
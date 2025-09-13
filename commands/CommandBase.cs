using System.Text.Json.Serialization;

namespace SimpleDispatch.SharedModels.Commands
{
    public abstract class CommandBase<TCommandType> where TCommandType : Enum
    {
        [JsonPropertyName("id")]
        public required Guid Id { get; set; }

        [JsonPropertyName("command")]
        public required TCommandType Command { get; set; }

        [JsonPropertyName("payload")]
        public required object Payload { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }

    // Generic base class for commands with strongly-typed payload
    public abstract class FlexibleCommandBase<TPayload>
    {
        [JsonPropertyName("id")]
        public required Guid Id { get; set; }

        [JsonPropertyName("command")]
        public required object Command { get; set; }

        [JsonPropertyName("payload")]
        public required TPayload Payload { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
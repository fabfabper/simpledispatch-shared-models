using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimpleDispatch.SharedModels.Dtos;

/// <summary>
/// Standard API response model
/// </summary>
/// <typeparam name="T">Type of the response data</typeparam>
public class ApiResponse<T>
{
    /// <summary>
    /// Indicates if the operation was successful
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary>
    /// Response message
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Response data
    /// </summary>
    [JsonPropertyName("data")]
    public T? Data { get; set; }

    /// <summary>
    /// Error details if operation failed
    /// </summary>
    [JsonPropertyName("error")] 
    public string? Error { get; set; }

    /// <summary>
    /// Timestamp of the response
    /// </summary>
    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Create a successful response
    /// </summary>
    public static ApiResponse<T> CreateSuccess(T data, string message = "Operation successful")
    {
        return new ApiResponse<T>
        {
            Success = true,
            Message = message,
            Data = data
        };
    }

    /// <summary>
    /// Create an error response
    /// </summary>
    public static ApiResponse<T> CreateError(string error, string message = "Operation failed")
    {
        return new ApiResponse<T>
        {
            Success = false,
            Message = message,
            Error = error
        };
    }
}

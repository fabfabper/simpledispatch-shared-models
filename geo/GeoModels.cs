using System.Text.Json.Serialization;

namespace SimpleDispatch.SharedModels.Geo;

/// <summary>
/// Represents location information including coordinates and address details
/// </summary>
public class LocationInfo
{
    /// <summary>
    /// Latitude coordinate
    /// </summary>
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate
    /// </summary>
    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    /// <summary>
    /// Full formatted address
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// City name
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Country name
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Postal/ZIP code
    /// </summary>
    [JsonPropertyName("postalcode")]
    public string PostalCode { get; set; } = string.Empty;
}

/// <summary>
/// Represents geographic coordinates
/// </summary>
public class Coordinates
{
    /// <summary>
    /// Latitude coordinate
    /// </summary>
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate
    /// </summary>
    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    /// <summary>
    /// Associated address
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; } = string.Empty;
}

/// <summary>
/// Request model for distance calculation
/// </summary>
public class DistanceRequest
{
    /// <summary>
    /// Origin coordinates
    /// </summary>
    [JsonPropertyName("origin")]
    public Coordinates Origin { get; set; } = new();

    /// <summary>
    /// Destination coordinates
    /// </summary>
    [JsonPropertyName("destination")]
    public Coordinates Destination { get; set; } = new();
}

/// <summary>
/// Response model for distance calculation
/// </summary>
public class DistanceInfo
{
    /// <summary>
    /// Origin coordinates
    /// </summary>
    [JsonPropertyName("origin")]
    public Coordinates Origin { get; set; } = new();

    /// <summary>
    /// Destination coordinates
    /// </summary>
    [JsonPropertyName("destination")]
    public Coordinates Destination { get; set; } = new();

    /// <summary>
    /// Distance in kilometers
    /// </summary>
    [JsonPropertyName("distancekm")]
    public double DistanceKm { get; set; }

    /// <summary>
    /// Distance in miles
    /// </summary>
    [JsonPropertyName("distancemiles")]
    public double DistanceMiles { get; set; }
}

/// <summary>
/// Autocomplete suggestion model
/// </summary>
public class AutocompleteSuggestion
{
    /// <summary>
    /// Suggested text/label
    /// </summary>
    [JsonPropertyName("label")]
    public string Label { get; set; } = string.Empty;

    /// <summary>
    /// Latitude coordinate
    /// </summary>
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate
    /// </summary>
    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    /// <summary>
    /// Location layer (address, venue, locality, etc.)
    /// </summary>
    [JsonPropertyName("layer")]
    public string Layer { get; set; } = string.Empty;

    /// <summary>
    /// Data source (osm, geonames, etc.)
    /// </summary>
    [JsonPropertyName("source")]
    public string Source { get; set; } = string.Empty;

    /// <summary>
    /// Confidence score (0-1)
    /// </summary>
    [JsonPropertyName("confidence")]
    public double Confidence { get; set; }

    /// <summary>
    /// City name
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Country name
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Region/state name
    /// </summary>
    [JsonPropertyName("region")]
    public string Region { get; set; } = string.Empty;
}
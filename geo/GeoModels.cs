namespace SimpleDispatch.SharedModels.Geo;

/// <summary>
/// Represents location information including coordinates and address details
/// </summary>
public class LocationInfo
{
    /// <summary>
    /// Latitude coordinate
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate
    /// </summary>
    public double Longitude { get; set; }

    /// <summary>
    /// Full formatted address
    /// </summary>
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// City name
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Country name
    /// </summary>
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Postal/ZIP code
    /// </summary>
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
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate
    /// </summary>
    public double Longitude { get; set; }

    /// <summary>
    /// Associated address
    /// </summary>
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
    public Coordinates Origin { get; set; } = new();

    /// <summary>
    /// Destination coordinates
    /// </summary>
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
    public Coordinates Origin { get; set; } = new();

    /// <summary>
    /// Destination coordinates
    /// </summary>
    public Coordinates Destination { get; set; } = new();

    /// <summary>
    /// Distance in kilometers
    /// </summary>
    public double DistanceKm { get; set; }

    /// <summary>
    /// Distance in miles
    /// </summary>
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
    public string Label { get; set; } = string.Empty;

    /// <summary>
    /// Latitude coordinate
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate
    /// </summary>
    public double Longitude { get; set; }

    /// <summary>
    /// Location layer (address, venue, locality, etc.)
    /// </summary>
    public string Layer { get; set; } = string.Empty;

    /// <summary>
    /// Data source (osm, geonames, etc.)
    /// </summary>
    public string Source { get; set; } = string.Empty;

    /// <summary>
    /// Confidence score (0-1)
    /// </summary>
    public double Confidence { get; set; }

    /// <summary>
    /// City name
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Country name
    /// </summary>
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Region/state name
    /// </summary>
    public string Region { get; set; } = string.Empty;
}
namespace SimpleDispatch.SharedModels.Geo;

/// <summary>
/// Pelias API response model for geocoding
/// </summary>
public class PeliasGeocodeResponse
{
    /// <summary>
    /// Geocoding results
    /// </summary>
    public List<PeliasFeature> Features { get; set; } = new();

    /// <summary>
    /// Response type
    /// </summary>
    public string Type { get; set; } = string.Empty;
}

/// <summary>
/// Pelias API response model for reverse geocoding
/// </summary>
public class PeliasReverseResponse
{
    /// <summary>
    /// Reverse geocoding results
    /// </summary>
    public List<PeliasFeature> Features { get; set; } = new();

    /// <summary>
    /// Response type
    /// </summary>
    public string Type { get; set; } = string.Empty;
}

/// <summary>
/// Pelias API response model for autocomplete
/// </summary>
public class PeliasAutocompleteResponse
{
    /// <summary>
    /// Autocomplete results
    /// </summary>
    public List<PeliasFeature> Features { get; set; } = new();

    /// <summary>
    /// Response type
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Query information
    /// </summary>
    public PeliasQuery? Query { get; set; }
}

/// <summary>
/// Query information from Pelias response
/// </summary>
public class PeliasQuery
{
    /// <summary>
    /// Original query text
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Query size (number of results)
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// Layers used in query
    /// </summary>
    public List<string> Layers { get; set; } = new();

    /// <summary>
    /// Sources used in query
    /// </summary>
    public List<string> Sources { get; set; } = new();
}

/// <summary>
/// Pelias feature representing a location
/// </summary>
public class PeliasFeature
{
    /// <summary>
    /// Feature type (usually "Feature")
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Geometry information
    /// </summary>
    public PeliasGeometry Geometry { get; set; } = new();

    /// <summary>
    /// Properties containing location details
    /// </summary>
    public PeliasProperties Properties { get; set; } = new();
}

/// <summary>
/// Pelias geometry containing coordinates
/// </summary>
public class PeliasGeometry
{
    /// <summary>
    /// Geometry type (usually "Point")
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Coordinates [longitude, latitude]
    /// </summary>
    public double[] Coordinates { get; set; } = new double[2];
}

/// <summary>
/// Pelias properties containing location information
/// </summary>
public class PeliasProperties
{
    /// <summary>
    /// Unique identifier
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Unique global identifier
    /// </summary>
    public string Gid { get; set; } = string.Empty;

    /// <summary>
    /// Location layer (e.g., address, venue, locality)
    /// </summary>
    public string Layer { get; set; } = string.Empty;

    /// <summary>
    /// Data source (e.g., osm, geonames)
    /// </summary>
    public string Source { get; set; } = string.Empty;

    /// <summary>
    /// Location name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Full address label
    /// </summary>
    public string Label { get; set; } = string.Empty;

    /// <summary>
    /// House number
    /// </summary>
    public string Housenumber { get; set; } = string.Empty;

    /// <summary>
    /// Street name
    /// </summary>
    public string Street { get; set; } = string.Empty;

    /// <summary>
    /// Postal code
    /// </summary>
    public string Postalcode { get; set; } = string.Empty;

    /// <summary>
    /// Locality (city/town)
    /// </summary>
    public string Locality { get; set; } = string.Empty;

    /// <summary>
    /// Region (state/province)
    /// </summary>
    public string Region { get; set; } = string.Empty;

    /// <summary>
    /// Country
    /// </summary>
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Country code
    /// </summary>
    public string Country_code { get; set; } = string.Empty;

    /// <summary>
    /// Confidence score
    /// </summary>
    public double Confidence { get; set; }
}
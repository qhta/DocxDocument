namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a geographic address used for chart data visualization and mapping features.
/// </summary>
/// <remarks>
///   This interface defines a structured address representation
///   used in chart drawings, particularly for geographic and map-based visualizations. The address contains
///   standardized components including street address, country/region, administrative districts, postal code,
///   locality, and ISO country code. This structured format enables accurate geocoding and location-based
///   data visualization in charts, supporting features such as map charts and geographic data series.
///   The address components follow international addressing standards to ensure compatibility across
///   different regions and mapping services.
/// </remarks>
public interface Address :
{
  /// <summary>
  ///   Gets or sets the primary street address line.
  /// </summary>
  /// <remarks>
   ///   This represents the first line of the street address and typically includes the building number
  ///   and street name (e.g., "123 Main Street").
  /// </remarks>
  public string? Address1 { get; set; }

  /// <summary>
  ///   Gets or sets the country or region name.
  /// </summary>
  /// <remarks>
   ///   This contains the human-readable country or region name (e.g., "United States", "Canada").
  ///   For programmatic country identification, use <see cref="IsoCountryCode"/>.
  /// </remarks>
  public string? CountryRegion { get; set; }

  /// <summary>
  ///   Gets or sets the first-level administrative district.
  /// </summary>
  /// <remarks>
   ///   This represents the largest sub-national administrative division, such as a state, province,
  ///   or region (e.g., "California" in the United States, "Ontario" in Canada).
  /// </remarks>
  public string? AdminDistrict1 { get; set; }

  /// <summary>
  ///   Gets or sets the second-level administrative district.
  /// </summary>
  /// <remarks>
   ///   This represents a sub-division of the first-level administrative district, such as a county,
  ///   district, or prefecture (e.g., "Los Angeles County" in California).
  /// </remarks>
  public string? AdminDistrict2 { get; set; }

  /// <summary>
  ///   Gets or sets the postal code or ZIP code.
  /// </summary>
  /// <remarks>
   ///   The postal code format varies by country (e.g., "90210" in the US, "SW1A 1AA" in the UK).
  /// </remarks>
  public string? PostalCode { get; set; }

  /// <summary>
  ///   Gets or sets the locality or city name.
  /// </summary>
  /// <remarks>
   ///   This represents the populated place name, typically a city or town (e.g., "Los Angeles", "Toronto").
  /// </remarks>
  public string? Locality { get; set; }

  /// <summary>
  ///   Gets or sets the ISO 3166-1 alpha-2 country code.
  /// </summary>
  /// <remarks>
   ///   The ISO country code provides a standardized, machine-readable country identifier using the
  ///   ISO 3166-1 alpha-2 format (e.g., "US" for United States, "CA" for Canada, "GB" for United Kingdom).
  ///   This is preferred over <see cref="CountryRegion"/> for programmatic operations and geocoding.
  /// </remarks>
  public string? IsoCountryCode { get; set; }
}
namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a geographic address used for chart data visualization and mapping features.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a structured address representation
///   used in chart drawings, particularly for geographic and map-based visualizations. The address contains
///   standardized components including street address, country/region, administrative districts, postal code,
///   locality, and ISO country code. This structured format enables accurate geocoding and location-based
///   data visualization in charts, supporting features such as map charts and geographic data series.
///   The address components follow international addressing standards to ensure compatibility across
///   different regions and mapping services.
/// </remarks>
public interface Address : IModelElement
{
  /// <summary>
  ///   Gets or sets the primary street address line.
  /// </summary>
  /// <value>
  ///   A string containing the street address (including street number, name, and type),
  ///   or <c>null</c> if no street address is specified.
  /// </value>
  /// <remarks>
   ///   This represents the first line of the street address and typically includes the building number
  ///   and street name (e.g., "123 Main Street").
  /// </remarks>
  public string? Address1 { get; set; }

  /// <summary>
  ///   Gets or sets the country or region name.
  /// </summary>
  /// <value>
  ///   A string containing the full country or region name,
  ///   or <c>null</c> if no country/region is specified.
  /// </value>
  /// <remarks>
   ///   This contains the human-readable country or region name (e.g., "United States", "Canada").
  ///   For programmatic country identification, use <see cref="IsoCountryCode"/>.
  /// </remarks>
  public string? CountryRegion { get; set; }

  /// <summary>
  ///   Gets or sets the first-level administrative district.
  /// </summary>
  /// <value>
  ///   A string containing the primary administrative division name,
  ///   or <c>null</c> if no first-level district is specified.
  /// </value>
  /// <remarks>
   ///   This represents the largest sub-national administrative division, such as a state, province,
  ///   or region (e.g., "California" in the United States, "Ontario" in Canada).
  /// </remarks>
  public string? AdminDistrict1 { get; set; }

  /// <summary>
  ///   Gets or sets the second-level administrative district.
  /// </summary>
  /// <value>
  ///   A string containing the secondary administrative division name,
  ///   or <c>null</c> if no second-level district is specified.
  /// </value>
  /// <remarks>
   ///   This represents a sub-division of the first-level administrative district, such as a county,
  ///   district, or prefecture (e.g., "Los Angeles County" in California).
  /// </remarks>
  public string? AdminDistrict2 { get; set; }

  /// <summary>
  ///   Gets or sets the postal code or ZIP code.
  /// </summary>
  /// <value>
  ///   A string containing the postal code,
  ///   or <c>null</c> if no postal code is specified.
  /// </value>
  /// <remarks>
   ///   The postal code format varies by country (e.g., "90210" in the US, "SW1A 1AA" in the UK).
  /// </remarks>
  public string? PostalCode { get; set; }

  /// <summary>
  ///   Gets or sets the locality or city name.
  /// </summary>
  /// <value>
  ///   A string containing the city, town, or locality name,
  ///   or <c>null</c> if no locality is specified.
  /// </value>
  /// <remarks>
   ///   This represents the populated place name, typically a city or town (e.g., "Los Angeles", "Toronto").
  /// </remarks>
  public string? Locality { get; set; }

  /// <summary>
  ///   Gets or sets the ISO 3166-1 alpha-2 country code.
  /// </summary>
  /// <value>
  ///   A string containing the two-letter ISO country code,
  ///   or <c>null</c> if no ISO code is specified.
  /// </value>
  /// <remarks>
   ///   The ISO country code provides a standardized, machine-readable country identifier using the
  ///   ISO 3166-1 alpha-2 format (e.g., "US" for United States, "CA" for Canada, "GB" for United Kingdom).
  ///   This is preferred over <see cref="CountryRegion"/> for programmatic operations and geocoding.
  /// </remarks>
  public string? IsoCountryCode { get; set; }
}
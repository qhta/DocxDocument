namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a query for geocoding address components to determine geographic coordinates and location information.
/// </summary>
/// <remarks>
///   This interface defines a geocoding query specification that converts
///   structured address components into geographic location data including coordinates, entity identification, and
///   complete address information. The query accepts partial or complete address information through administrative
///   division properties (<see cref="CountryRegion"/>, <see cref="AdminDistrict1"/>, <see cref="AdminDistrict2"/>),
///   postal code (<see cref="PostalCode"/>), and optional entity type filtering (<see cref="EntityType"/>), enabling
///   flexible geocoding from various levels of address specificity. This geocoding mechanism is essential for map-based
///   charts that need to convert address data into mappable coordinates, supporting scenarios where data sources contain
///   address information rather than explicit geographic coordinates. The query results typically return <see cref="GeoLocation"/>
///   objects containing coordinates (latitude/longitude), entity identification, and complete structured address data,
///   stored in <see cref="GeoLocationQueryResults"/> within the <see cref="Clear"/> structure, which can be cached in
///   <see cref="GeoCache"/> for offline access and performance optimization. Common use cases include geocoding customer
///   addresses for sales territory mapping, converting facility addresses to coordinates for location visualization,
///   plotting demographic data specified by administrative divisions and postal codes, or resolving partial address
///   information to complete geographic locations. The hierarchical address structure supports various geocoding
///   granularities: country-only queries for national-level mapping, country + state queries for regional analysis,
///   or complete address queries including postal codes for precise location identification. The entity type filter
///   helps target specific geographic classification levels, such as querying for cities, counties, or other entity
///   types within the specified address components. This flexible address-based query mechanism enables charts to work
///   with diverse data sources that specify locations through addresses, administrative boundaries, or postal codes
///   rather than explicit coordinates, automatically converting these references into mappable geographic positions.
/// </remarks>
public interface GeoLocationQuery : IModelElement
{
  /// <summary>
  ///   Gets or sets the country or region component of the address query.
  /// </summary>
  /// <remarks>
   ///   The country or region specifies the top-level geographic context for the location query, identifying the
  ///   nation or sovereign region within which the location exists. This can be specified using full country names
  ///   (e.g., "United States", "United Kingdom", "Japan"), common abbreviations (e.g., "USA", "UK"), or ISO country
  ///   codes (e.g., "US", "GB", "JP"). The country/region is essential for disambiguating locations, as many place
  ///   names, postal codes, and administrative divisions are not globally unique. For example, "Georgia" could refer
  ///   to the U.S. state or the country, and specifying the country resolves this ambiguity. When geocoding, the
  ///   country/region establishes the geographic scope, ensuring results are constrained to the correct nation and
  ///   administrative hierarchy. This property can be used alone for country-level geocoding or combined with lower-level
  ///   administrative divisions for more precise location identification.
  /// </remarks>
  public string? CountryRegion { get; set; }

  /// <summary>
  ///   Gets or sets the first-level administrative division component of the address query.
  /// </summary>
  /// <remarks>
   ///   The first-level administrative division represents the primary sub-national geographic unit, such as states
  ///   in the United States (e.g., "California", "New York"), provinces in Canada (e.g., "Ontario", "British Columbia"),
  ///   prefectures in Japan, or equivalent divisions in other countries. This division narrows the geographic scope
  ///   from the country level to a major regional subdivision, enabling more precise location identification. The
  ///   division can be specified using full names, abbreviations (e.g., "CA" for California, "NY" for New York), or
  ///   other commonly recognized identifiers. When combined with <see cref="CountryRegion"/>, this provides state-level
  ///   or provincial-level geocoding. When further combined with <see cref="AdminDistrict2"/> or <see cref="PostalCode"/>,
  ///   it enables more precise location resolution within the specified administrative context.
  /// </remarks>
  public string? AdminDistrict1 { get; set; }

  /// <summary>
  ///   Gets or sets the second-level administrative division component of the address query.
  /// </summary>
  /// <remarks>
   ///   The second-level administrative division represents a sub-division of the first-level division, such as counties
  ///   within U.S. states (e.g., "Los Angeles County" within California, "Cook County" within Illinois), districts within
  ///   provinces, or equivalent subdivisions in other administrative systems. This division provides finer geographic
  ///   granularity than first-level divisions, enabling more precise location identification for detailed regional
  ///   analysis. When combined with higher-level address components (<see cref="CountryRegion"/> and <see cref="AdminDistrict1"/>),
  ///   this enables county-level or district-level geocoding. The second-level division is particularly valuable for
  ///   demographic analysis, local government mapping, or regional business intelligence where county or district-level
  ///   geographic aggregation is required.
  /// </remarks>
  public string? AdminDistrict2 { get; set; }

  /// <summary>
  ///   Gets or sets the postal code component of the address query.
  /// </summary>
  /// <remarks>
   ///   The postal code provides precise geographic localization through mail delivery codes, such as ZIP codes in the
  ///   United States (e.g., "90210", "10001"), postcodes in the United Kingdom (e.g., "SW1A 1AA"), or equivalent codes
  ///   in other countries. Postal codes enable high-precision geocoding as they typically correspond to small geographic
  ///   areas (neighborhoods, districts, or specific delivery zones). When combined with administrative divisions, postal
  ///   codes can resolve locations to very specific areas, enabling detailed geographic visualization. The postal code
  ///   format varies by country, and geocoding services use the postal code in conjunction with the country/region to
  ///   interpret the code correctly. Postal code-based geocoding is particularly valuable for customer address mapping,
  ///   delivery route visualization, or any scenario requiring precise neighborhood-level geographic positioning.
  /// </remarks>
  public string? PostalCode { get; set; }

  /// <summary>
  ///   Gets or sets the type of geographic entity to target in the location query.
  /// </summary>
  /// <remarks>
   ///   The entity type specifies the desired geographic classification level to target in the geocoding operation,
  ///   such as country, first-level administrative division (state/province), second-level administrative division
  ///   (county/district), populated place (city/town), or other classifications. This filtering helps refine geocoding
  ///   results when address components could match multiple entity types. For example, querying with "Georgia" and
  ///   "US" could match the state of Georgia (AdminDivision1) or cities named Georgia within the U.S.; specifying
  ///   entity type as "AdminDivision1" ensures the query targets the state. The entity type filter works in conjunction
  ///   with the address components to provide precise, targeted geocoding results. When no entity type is specified,
  ///   the geocoding service determines the most appropriate entity based on the provided address components and its
  ///   internal resolution logic, typically returning the most specific entity that matches the address data.
  /// </remarks>
  public EntityTypeEnum? EntityType { get; set; }
}
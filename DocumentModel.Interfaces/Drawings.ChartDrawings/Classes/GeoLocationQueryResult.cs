namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the result of a geographic location query, containing both the query specification and retrieved location data.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a query result structure that pairs a geographic
///   location query (<see cref="GeoLocationQuery"/>) with its corresponding location results (<see cref="GeoLocations"/>).
///   This structure preserves the association between the query parameters (address components including country, administrative
///   divisions, postal code, and optional entity type) and the geographic locations retrieved through geocoding operations.
///   By maintaining this query-result pairing, the interface enables efficient caching and retrieval of geocoded location
///   data in map-based charts. The query result is stored within the <see cref="Clear"/> structure as part of
///   <see cref="GeoLocationQueryResults"/>, which can be cached in <see cref="GeoCache"/> to support offline access and
///   improve performance by eliminating redundant queries to external mapping services. This structure is particularly
///   valuable for map-based charts that need to convert address data into mappable coordinates and complete location
///   information for visualization. The geocoding operation may return multiple location results in cases where the
///   address components are ambiguous or match multiple geographic entities (such as multiple cities with the same name
///   in different states or countries). By caching query results, the chart can respond immediately to repeated geocoding
///   requests for the same address without requiring new queries to external services. The query-result pairing also
///   enables query validation and cache management, where cached results can be matched against query parameters to
///   determine if a cached result satisfies a new query or if fresh geocoding data needs to be retrieved. This optimization
///   is essential for maintaining responsive map chart rendering while minimizing network traffic and external service
///   dependencies. Common use cases include caching geocoded customer addresses for sales territory mapping, storing
///   facility location results for repeated visualization, maintaining demographic location data for regional analysis,
///   or preserving address resolution results for consistent map chart rendering across document sessions.
/// </remarks>
public interface GeoLocationQueryResult : IModelElement
{
  /// <summary>
  ///   Gets or sets the query specification that was used to retrieve the geographic locations.
  /// </summary>
  /// <remarks>
  ///   The query specification preserves the address components used to perform the geocoding operation, including
  ///   the country/region, first-level administrative division (state/province), second-level administrative division
  ///   (county/district), postal code, and optional entity type filter. This enables cache validation by comparing
  ///   new geocoding queries against cached queries to determine if a cached result is still valid and applicable.
  ///   For example, if a chart geocodes an address in "California, United States" with postal code "90210", the query
  ///   specification stores these parameters. When the chart later needs to geocode the same or similar address, the
  ///   cached query can be matched against the new geocoding request to quickly retrieve the previously resolved
  ///   location data without querying the mapping service again. The query specification also provides context for
  ///   understanding the cached location data, documenting what address information was used to resolve the locations
  ///   and enabling informed decisions about cache refresh, expiration, or replacement strategies. This is particularly
  ///   important for managing cached geocoding results where the same address might be queried with different levels
  ///   of specificity (such as country-only vs. country + state + postal code), ensuring the cached data matches the
  ///   granularity and detail level of the current geocoding requirements.
  /// </remarks>
  public GeoLocationQuery? GeoLocationQuery { get; set; }

  /// <summary>
  ///   Gets or sets the collection of geographic locations retrieved by the geocoding query.
  /// </summary>
  /// <remarks>
  ///   The geographic locations collection contains the complete location information retrieved through geocoding the
  ///   address components specified in the <see cref="GeoLocationQuery"/>. Each location in the collection includes
  ///   coordinates (latitude/longitude), entity identification (entity name and type), and detailed structured address
  ///   data. The collection may contain multiple locations when the address components are ambiguous or match multiple
  ///   geographic entities. For example, querying for "Springfield" in the "United States" might return multiple results
  ///   for different cities named Springfield in different states. The geocoding service typically orders results by
  ///   relevance or confidence, with the most likely match appearing first. These cached location results enable
  ///   immediate conversion of address data into mappable coordinates for chart visualization, supporting offline viewing
  ///   and improving performance for repeated geocoding operations. The locations remain associated with their originating
  ///   query through this pairing, ensuring that cached geocoding data can be correctly matched to future address
  ///   resolution requests and enabling efficient cache management. The complete location information (coordinates,
  ///   entity identification, and address) eliminates the need for separate queries for different aspects of location
  ///   data, providing all geocoding results in a single, cohesive structure. See <see cref="GeoLocations"/> for details
  ///   on the structure and content of the geocoded locations collection.
  /// </remarks>
  public GeoLocations? GeoLocations { get; set; }
}
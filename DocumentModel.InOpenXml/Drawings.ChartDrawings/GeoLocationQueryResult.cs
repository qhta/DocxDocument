namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents the result of a geographic location query, containing both the query specification and retrieved location data.
/// </summary>
/// <remarks>
///   This class defines a query result structure that pairs a geographic
///   location query (<see cref = "GeoLocationQuery"/>) with its corresponding location results (<see cref = "GeoLocations"/>).
///   This structure preserves the association between the query parameters (address components including country, administrative
///   divisions, postal code, and optional entity type) and the geographic locations retrieved through geocoding operations.
///   By maintaining this query-result pairing, the class enables efficient caching and retrieval of geocoded location
///   data in map-based charts. The query result is stored within the <see cref = "Clear"/> structure as part of
///   <see cref = "GeoLocationQueryResults"/>, which can be cached in <see cref = "GeoCache"/> to support offline access and
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
[OpenXmlType(typeof(DXO16DCD.GeoLocationQueryResult))]
[XmlRoot("GeoLocationQueryResult", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class GeoLocationQueryResult : ModelElement<DXO16DCD.GeoLocationQueryResult>
{
  /// <summary>
  /// Specifies the geo location query.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoLocationQueryResult.GeoLocationQuery))]
  public GeoLocationQuery? GeoLocationQuery { get => _GeoLocationQuery; set => UpdateField(ref _GeoLocationQuery, value, nameof(GeoLocationQuery)); }

  private GeoLocationQuery? _GeoLocationQuery;
  /// <summary>
  /// Specifies the geo locations.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoLocationQueryResult.GeoLocations))]
  public GeoLocations? GeoLocations { get => _GeoLocations; set => UpdateField(ref _GeoLocations, value, nameof(GeoLocations)); }

  private GeoLocations? _GeoLocations;
}
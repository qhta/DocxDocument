namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the result of a data point-to-entity mapping query, containing both coordinate-based and entity-based query specifications.
/// </summary>
/// <remarks>
///   This class defines a query result structure that pairs multiple query
///   approaches for mapping data points to geographic entities. The result can contain both a coordinate-based query
///   (<see cref = "GeoDataPointQuery"/>) that identifies entities by latitude/longitude position, and an entity-based
///   query (<see cref = "GeoDataPointToEntityQuery"/>) that directly references entities by identifier. This dual-query
///   structure supports flexible data point-to-entity mapping where the association can be established through either
///   coordinate reverse geocoding or direct entity reference, accommodating different data source formats and mapping
///   requirements. The query result is stored within the <see cref = "Clear"/> structure as part of
///   <see cref = "GeoDataPointToEntityQueryResults"/>, which can be cached in <see cref = "GeoCache"/> to support offline
///   access and improve performance by eliminating redundant queries to external mapping services. This structure is
///   particularly valuable for map-based charts that need to handle mixed data sources where some data points are
///   specified by coordinates (requiring reverse geocoding to find containing entities) while others are pre-categorized
///   with entity identifiers (enabling direct entity mapping). By maintaining both query types in the result, the
///   class enables comprehensive caching and validation strategies that can match new data point mappings against
///   either query approach. Common scenarios include mapping sales data where some records have geographic coordinates
///   while others have country/region codes, handling user input that might provide either addresses (converted to
///   coordinates) or explicit region selections, or integrating data from multiple sources with different geographic
///   reference formats. The dual-query capability ensures efficient cache utilization regardless of how the geographic
///   association is specified, supporting responsive map chart rendering while minimizing external service dependencies.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoDataPointToEntityQueryResult))]
public class GeoDataPointToEntityQueryResult: ModelElement<DXO16DCD.GeoDataPointToEntityQueryResult>
{
  /// <summary>
  /// Specifies the geo data point query.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoDataPointToEntityQueryResult.GeoDataPointQuery))]
  public GeoDataPointQuery? GeoDataPointQuery
  {
    get => _GeoDataPointQuery;
    set => UpdateField(ref _GeoDataPointQuery, value, nameof(GeoDataPointQuery));
  }

  private GeoDataPointQuery? _GeoDataPointQuery;

  /// <summary>
  /// Specifies the geo data point to entity query.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoDataPointToEntityQueryResult.GeoDataPointToEntityQuery))]
  public GeoDataPointToEntityQuery? GeoDataPointToEntityQuery
  {
    get => _GeoDataPointToEntityQuery;
    set => UpdateField(ref _GeoDataPointToEntityQuery, value, nameof(GeoDataPointToEntityQuery));
  }

  private GeoDataPointToEntityQuery? _GeoDataPointToEntityQuery;
}
namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents the result of a geographic child entities query, containing both the query specification and retrieved data.
/// </summary>
/// <remarks>
///   This class defines a query result structure that pairs a geographic
///   child entities query (<see cref = "GeoChildEntitiesQuery"/>) with its corresponding results (<see cref = "GeoChildEntities"/>).
///   This structure preserves the association between the query parameters (parent entity identifier and optional child
///   type filters) and the geographic entities retrieved in response to that query. By maintaining this query-result
///   pairing, the class enables efficient caching and retrieval of geographic data in map-based charts. The query
///   result is stored within the <see cref = "Clear"/> structure as part of <see cref = "GeoChildEntitiesQueryResults"/>,
///   which can be cached in <see cref = "GeoCache"/> to support offline access and improve performance by eliminating
///   redundant queries to external mapping services. This structure is particularly valuable for interactive map charts
///   that support drill-down navigation, where users explore geographic hierarchies by selecting parent regions to reveal
///   their child entities. By caching query results, the chart can respond immediately to repeated navigation actions
///   (such as drilling down, backing up, and drilling down again to the same level) without requiring new queries to
///   external services. The query-result pairing also enables query validation and cache management, where the cached
///   results can be matched against query parameters to determine if a cached result satisfies a new query or if a
///   fresh query to the mapping service is needed. This optimization is essential for maintaining responsive user
///   interactions in geographic visualizations while minimizing network traffic and external service dependencies.
///   Common use cases include caching the states within a country after the first drill-down, storing counties within
///   a state for repeated access, or maintaining city-level data for quick navigation within regional hierarchies.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoChildEntitiesQueryResult))]
public class GeoChildEntitiesQueryResult: ModelElement<DXO16DCD.GeoChildEntitiesQueryResult>
{
  /// <summary>
  /// Specifies the geo child entities query.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoChildEntitiesQueryResult.GeoChildEntitiesQuery))]
  public GeoChildEntitiesQuery? GeoChildEntitiesQuery
  {
    get => _GeoChildEntitiesQuery;
    set => UpdateField(ref _GeoChildEntitiesQuery, value, nameof(GeoChildEntitiesQuery));
  }
  private GeoChildEntitiesQuery? _GeoChildEntitiesQuery;
  /// <summary>
  /// Specifies the geo child entities.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoChildEntitiesQueryResult.GeoChildEntities))]
  public GeoChildEntities? GeoChildEntities
  {
    get => _GeoChildEntities;
    set => UpdateField(ref _GeoChildEntities, value, nameof(GeoChildEntities));
  }
  private GeoChildEntities? _GeoChildEntities;
}
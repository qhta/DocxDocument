namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the result of a parent entities query, containing the query specification and retrieved parent entity data.
/// </summary>
/// <remarks>
///   This class defines a query result structure that pairs a parent
///   entities query (<see cref = "GeoParentEntitiesQuery"/>) with its corresponding results, which may include both
///   the child entity (<see cref = "GeoEntity"/>) and its direct parent entity (<see cref = "GeoParentEntity"/>). This
///   structure preserves the association between the query parameter (child entity identifier) and the parent entity
///   information retrieved through upward hierarchical navigation. By maintaining this query-result pairing, the
///   class enables efficient caching and retrieval of parent entity relationships in map-based charts. The query
///   result is stored within the <see cref = "Clear"/> structure as part of <see cref = "GeoParentEntitiesQueryResults"/>,
///   which can be cached in <see cref = "GeoCache"/> to support offline access and improve performance by eliminating
///   redundant queries to external mapping services. This structure is particularly valuable for map-based charts
///   that support drill-up navigation, where users navigate from detailed regions to broader containing regions,
///   requiring knowledge of parent-child geographic relationships. The result structure includes both the child entity
///   (providing context about which entity was queried) and the parent entity (providing the containment information),
///   enabling complete understanding of the hierarchical relationship. By caching query results, the chart can respond
///   immediately to repeated navigation actions (such as drilling up, backing down, and drilling up again) without
///   requiring new queries to external services. The query-result pairing also enables query validation and cache
///   management, where cached results can be matched against query parameters to determine if a cached result satisfies
///   a new query or if fresh parent entity data needs to be retrieved. This optimization is essential for maintaining
///   responsive user interactions in geographic visualizations while minimizing network traffic and external service
///   dependencies. Common use cases include caching parent relationships for counties within states, states within
///   countries, or cities within regions for quick navigation through geographic hierarchies.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoParentEntitiesQueryResult))]
public class GeoParentEntitiesQueryResult: ModelElement<DXO16DCD.GeoParentEntitiesQueryResult>
{
  /// <summary>
  /// Specifies the geo parent entities query.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoParentEntitiesQueryResult.GeoParentEntitiesQuery))]
  public GeoParentEntitiesQuery? GeoParentEntitiesQuery
  {
    get => _GeoParentEntitiesQuery;
    set => UpdateField(ref _GeoParentEntitiesQuery, value, nameof(GeoParentEntitiesQuery));
  }

  private GeoParentEntitiesQuery? _GeoParentEntitiesQuery;

  /// <summary>
  /// Specifies the geo entity.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoParentEntitiesQueryResult.GeoEntity))]
  public GeoEntity? GeoEntity { get => _GeoEntity; set => UpdateField(ref _GeoEntity, value, nameof(GeoEntity)); }

  private GeoEntity? _GeoEntity;

  /// <summary>
  /// Specifies the geo parent entity.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoParentEntitiesQueryResult.GeoParentEntity))]
  public GeoParentEntity? GeoParentEntity
  {
    get => _GeoParentEntity;
    set => UpdateField(ref _GeoParentEntity, value, nameof(GeoParentEntity));
  }

  private GeoParentEntity? _GeoParentEntity;
}
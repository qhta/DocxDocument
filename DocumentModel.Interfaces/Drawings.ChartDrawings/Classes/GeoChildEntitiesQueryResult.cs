namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the result of a geographic child entities query, containing both the query specification and retrieved data.
/// </summary>
/// <remarks>
///   This interface defines a query result structure that pairs a geographic
///   child entities query (<see cref="GeoChildEntitiesQuery"/>) with its corresponding results (<see cref="GeoChildEntities"/>).
///   This structure preserves the association between the query parameters (parent entity identifier and optional child
///   type filters) and the geographic entities retrieved in response to that query. By maintaining this query-result
///   pairing, the interface enables efficient caching and retrieval of geographic data in map-based charts. The query
///   result is stored within the <see cref="Clear"/> structure as part of <see cref="GeoChildEntitiesQueryResults"/>,
///   which can be cached in <see cref="GeoCache"/> to support offline access and improve performance by eliminating
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
public interface GeoChildEntitiesQueryResult :
{
  /// <summary>
  ///   Gets or sets the query specification that was used to retrieve the child entities.
  /// </summary>
  /// <remarks>
  ///   The query specification preserves the parameters used to retrieve the child entities, including the parent
  ///   entity identifier and any child type filters that were applied. This enables cache validation by comparing
  ///   new query parameters against cached queries to determine if a cached result is still valid and applicable.
  ///   For example, if a user drills down into "United States" to see states, the query specification stores
  ///   the parent entity ID ("US") and potentially the child type filter (administrative subdivisions). When the
  ///   user later returns to this level, the cached query can be matched against the new navigation action to
  ///   quickly retrieve the previously loaded state data without querying the mapping service again. The query
  ///   specification also provides context for understanding the cached data, documenting what was requested and
  ///   enabling informed decisions about cache refresh, expiration, or replacement strategies.
  /// </remarks>
  public GeoChildEntitiesQuery? GeoChildEntitiesQuery { get; set; }

  /// <summary>
  ///   Gets or sets the collection of child geographic entities retrieved by the query.
  /// </summary>
  /// <remarks>
  ///   The child entities collection contains the geographic regions retrieved in response to the query, representing
  ///   the subdivisions within the parent entity specified in the <see cref="GeoChildEntitiesQuery"/>. For example,
  ///   if the query requested child entities for "United States", the results would contain the individual states;
  ///   if the query was for "California", the results would contain California's counties. These cached results enable
  ///   immediate display of geographic details when users interact with the map chart, supporting drill-down navigation,
  ///   hierarchical data visualization, and progressive detail display without requiring repeated network requests to
  ///   external mapping services. The results remain associated with their originating query through this pairing,
  ///   ensuring that the cached data can be correctly matched to future query requests and enabling efficient cache
  ///   management. The collection may include entity identifiers, names, boundaries, and other geographic properties
  ///   needed to render the child entities on the map chart. See <see cref="GeoChildEntities"/> for details on the
  ///   structure and content of the child entities collection.
  /// </remarks>
  public GeoChildEntities? GeoChildEntities { get; set; }
}
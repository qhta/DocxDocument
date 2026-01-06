namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the result of a parent entities query, containing the query specification and retrieved parent entity data.
/// </summary>
/// <remarks>
///   This interface defines a query result structure that pairs a parent
///   entities query (<see cref="GeoParentEntitiesQuery"/>) with its corresponding results, which may include both
///   the child entity (<see cref="GeoEntity"/>) and its direct parent entity (<see cref="GeoParentEntity"/>). This
///   structure preserves the association between the query parameter (child entity identifier) and the parent entity
///   information retrieved through upward hierarchical navigation. By maintaining this query-result pairing, the
///   interface enables efficient caching and retrieval of parent entity relationships in map-based charts. The query
///   result is stored within the <see cref="Clear"/> structure as part of <see cref="GeoParentEntitiesQueryResults"/>,
///   which can be cached in <see cref="GeoCache"/> to support offline access and improve performance by eliminating
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
public interface GeoParentEntitiesQueryResult
{
  /// <summary>
  ///   Gets or sets the query specification that was used to retrieve the parent entities.
  /// </summary>
  /// <remarks>
  ///   The query specification preserves the child entity identifier used to retrieve parent entities, enabling
  ///   cache validation by comparing new query parameters against cached queries to determine if a cached result
  ///   is still valid and applicable. For example, if a user drills up from "Los Angeles County" to see its containing
  ///   entities, the query specification stores the child entity identifier for Los Angeles County. When the user
  ///   later returns to this hierarchical level or performs similar navigation, the cached query can be matched
  ///   against the new request to quickly retrieve the previously loaded parent entity data (California, United States)
  ///   without querying the mapping service again. The query specification also provides context for understanding
  ///   the cached parent entity data, documenting which child entity was queried and enabling informed decisions
  ///   about cache refresh, expiration, or replacement strategies.
  /// </remarks>
  public GeoParentEntitiesQuery? GeoParentEntitiesQuery { get; set; }

  /// <summary>
  ///   Gets or sets the child geographic entity for which parent entities were queried.
  /// </summary>
  /// <remarks>
  ///   The child entity provides lightweight identification information (name and type) about the entity for which
  ///   parent entities were queried. This context information helps users understand the hierarchical relationship
  ///   by showing which entity is contained within the parent entities. For example, if querying for parents of
  ///   "Los Angeles County", the GeoEntity would contain the name "Los Angeles County" and type "AdminDivision2"
  ///   (second-level administrative division), providing context for the parent relationship results. The child
  ///   entity reference enables breadcrumb-style navigation displays that show the complete hierarchical path,
  ///   supports drill-up/drill-down navigation by maintaining awareness of the current position in the hierarchy,
  ///   and facilitates data aggregation by clearly identifying the source entity from which data is being rolled up
  ///   to parent levels. See <see cref="GeoEntity"/> for details on the lightweight entity identification structure.
  /// </remarks>
  public GeoEntity? GeoEntity { get; set; }

  /// <summary>
  ///   Gets or sets the parent geographic entity that contains the queried child entity.
  /// </summary>
  /// <remarks>
  ///   The parent entity provides information about the geographic entity that contains or encompasses the child
  ///   entity specified in the query. This represents one level up in the geographic hierarchy, such as the state
  ///   that contains a county, the country that contains a state, or the continent that contains a country. For
  ///   example, if querying for parents of "Los Angeles County", the GeoParentEntity would represent "California"
  ///   (the containing state). The parent entity information enables upward hierarchical navigation in map charts,
  ///   supports drill-up operations where users navigate from detailed regions to broader containing regions, provides
  ///   context for breadcrumb navigation showing the hierarchical path, and enables data aggregation where values
  ///   from child entities are rolled up to their parent entities for summary views. When multiple parent entities
  ///   exist at different hierarchy levels (such as both state and country), separate query results may be needed
  ///   for each level, or the parent entity structure may support representing multiple containment levels. The
  ///   parent entity remains associated with its originating query through this pairing, ensuring that cached
  ///   hierarchical relationship data can be correctly matched to future navigation requests and enabling efficient
  ///   cache management for responsive geographic hierarchy exploration.
  /// </remarks>
  public GeoParentEntity? GeoParentEntity { get; set; }
}
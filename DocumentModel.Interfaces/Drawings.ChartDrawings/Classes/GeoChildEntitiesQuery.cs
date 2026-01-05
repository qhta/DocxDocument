namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a query for retrieving child geographic entities within a specific parent geographic entity.
/// </summary>
/// <remarks>
///   This interface defines a query specification used to retrieve child
///   geographic entities that are contained within a parent geographic entity. The query enables map-based charts
///   to request hierarchical geographic information from mapping services or cached geographic data, supporting
///   drill-down navigation and progressive detail display in geographic visualizations. By specifying a parent
///   entity identifier (<see cref="EntityId"/>) and optionally filtering by child entity types (<see cref="GeoChildTypes"/>),
///   the query can retrieve specific subsets of child entities such as states within a country, counties within a
///   state, or cities within a region. The query results are typically stored in <see cref="GeoChildEntitiesQueryResults"/>
///   within the <see cref="Clear"/> structure, which can be cached in <see cref="GeoCache"/> for offline access and
///   performance optimization. This query mechanism is fundamental to interactive map charts that allow users to
///   navigate geographic hierarchies, where selecting a parent region triggers queries for its child entities to
///   display more detailed geographic data. The query supports various use cases including dynamic drill-down (loading
///   child entities on demand when users interact with parent regions), hierarchical data exploration (progressively
///   revealing more detailed geographic levels), and selective loading (retrieving only specific types of child
///   entities to optimize performance and reduce data transfer). The query structure enables efficient geographic
///   data retrieval by targeting specific parent-child relationships rather than loading entire geographic hierarchies,
///   making it practical to work with large geographic datasets while maintaining responsive chart interactions.
/// </remarks>
public interface GeoChildEntitiesQuery :
{
  /// <summary>
  ///   Gets or sets the identifier of the parent geographic entity whose child entities are being queried.
  /// </summary>
  /// <remarks>
   ///   The entity identifier uniquely identifies the parent geographic entity for which child entities are being
  ///   requested. This ID typically corresponds to a geographic entity defined in the mapping service's data model,
  ///   such as a country code, state identifier, or region reference. For example, querying for child entities of
  ///   "US" (United States) would retrieve its states, or querying for "CA" (California) would retrieve its counties.
  ///   The identifier format depends on the geographic data provider specified in <see cref="GeoCache.Provider"/>,
  ///   which determines how entities are identified and referenced. The entity ID enables precise targeting of the
  ///   parent entity in the geographic hierarchy, ensuring that the query returns only the relevant child entities
  ///   rather than unrelated geographic regions. This targeted approach is essential for efficient data retrieval
  ///   and enables responsive map chart interactions where users can drill down through multiple levels of geographic
  ///   detail without loading unnecessary data.
  /// </remarks>
  public string? EntityId { get; set; }

  /// <summary>
  ///   Gets or sets the types of child entities to retrieve in the query.
  /// </summary>
  /// <remarks>
  ///   The child types specification enables filtering of the query results to include only specific categories
  ///   of child entities, such as administrative divisions (states, provinces), statistical regions, cities, or
  ///   custom geographic classifications. This filtering capability is valuable for optimizing query performance
  ///   by retrieving only the types of entities needed for the specific map visualization, reducing data transfer
  ///   and processing overhead. For example, a chart visualizing state-level data might query only for administrative
  ///   subdivisions (states/provinces) while excluding cities or postal codes, or a regional analysis might focus
  ///   on specific types of economic zones or statistical areas. When this property is <c>null</c> or not specified,
  ///   the query typically returns all types of child entities available within the parent entity, providing complete
  ///   hierarchical information. The ability to filter by child types enables more efficient geographic data management
  ///   and allows charts to request precisely the level and type of detail needed for their specific visualization
  ///   requirements, balancing data completeness with performance and resource constraints.
  /// </remarks>
  public GeoChildTypes? GeoChildTypes { get; set; }
}
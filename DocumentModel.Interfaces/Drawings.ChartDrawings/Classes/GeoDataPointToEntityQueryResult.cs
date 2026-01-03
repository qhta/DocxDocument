namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the result of a data point-to-entity mapping query, containing both coordinate-based and entity-based query specifications.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a query result structure that pairs multiple query
///   approaches for mapping data points to geographic entities. The result can contain both a coordinate-based query
///   (<see cref="GeoDataPointQuery"/>) that identifies entities by latitude/longitude position, and an entity-based
///   query (<see cref="GeoDataPointToEntityQuery"/>) that directly references entities by identifier. This dual-query
///   structure supports flexible data point-to-entity mapping where the association can be established through either
///   coordinate reverse geocoding or direct entity reference, accommodating different data source formats and mapping
///   requirements. The query result is stored within the <see cref="Clear"/> structure as part of
///   <see cref="GeoDataPointToEntityQueryResults"/>, which can be cached in <see cref="GeoCache"/> to support offline
///   access and improve performance by eliminating redundant queries to external mapping services. This structure is
///   particularly valuable for map-based charts that need to handle mixed data sources where some data points are
///   specified by coordinates (requiring reverse geocoding to find containing entities) while others are pre-categorized
///   with entity identifiers (enabling direct entity mapping). By maintaining both query types in the result, the
///   interface enables comprehensive caching and validation strategies that can match new data point mappings against
///   either query approach. Common scenarios include mapping sales data where some records have geographic coordinates
///   while others have country/region codes, handling user input that might provide either addresses (converted to
///   coordinates) or explicit region selections, or integrating data from multiple sources with different geographic
///   reference formats. The dual-query capability ensures efficient cache utilization regardless of how the geographic
///   association is specified, supporting responsive map chart rendering while minimizing external service dependencies.
/// </remarks>
public interface GeoDataPointToEntityQueryResult : IModelElement
{
  /// <summary>
  ///   Gets or sets the coordinate-based query specification used to identify the containing entity.
  /// </summary>
  /// <value>
  ///   A <see cref="GeoDataPointQuery"/> object defining the coordinate-based query parameters,
  ///   or <c>null</c> if no coordinate-based query is stored.
  /// </value>
  /// <remarks>
  ///   The coordinate-based query specification preserves the latitude/longitude coordinates and optional entity
  ///   type used to perform reverse geocoding, identifying which geographic entity contains the specified point.
  ///   This enables cache validation for coordinate-based data point mappings by comparing new coordinate queries
  ///   against cached queries to determine if a cached result is applicable. For example, if a data point at
  ///   coordinates (37.7749, -122.4194) was previously mapped to San Francisco or California, the cached query
  ///   can be matched against new coordinate-based mapping requests for the same or nearby locations. The coordinate
  ///   query approach is essential for data sources that specify locations by geographic coordinates, such as GPS
  ///   data, geocoded addresses, or spatial data from GIS systems. When this property is populated, it indicates
  ///   the entity mapping was derived through reverse geocoding rather than direct entity reference.
  /// </remarks>
  public GeoDataPointQuery? GeoDataPointQuery { get; set; }

  /// <summary>
  ///   Gets or sets the entity-based query specification used to directly reference the target entity.
  /// </summary>
  /// <value>
  ///   A <see cref="GeoDataPointToEntityQuery"/> object defining the entity-based query parameters,
  ///   or <c>null</c> if no entity-based query is stored.
  /// </value>
  /// <remarks>
  ///   The entity-based query specification preserves the entity identifier and optional entity type used to
  ///   directly associate the data point with a specific geographic entity. This enables cache validation for
  ///   entity-reference-based data point mappings by comparing new entity queries against cached queries to
  ///   determine if a cached result is applicable. For example, if a data point labeled with entity ID "US"
  ///   (United States) was previously mapped to the U.S. entity, the cached query can be matched against new
  ///   entity-based mapping requests using the same identifier. The entity-based query approach is essential for
  ///   data sources that pre-categorize data by geographic identifiers, such as sales data with country codes,
  ///   demographic data with state abbreviations, or business metrics with region IDs. When this property is
  ///   populated, it indicates the entity mapping was established through direct entity reference rather than
  ///   coordinate-based lookup. The interface allows both query types to be stored, supporting scenarios where
  ///   the same data point might be mapped using either approach or where caching strategies need to maintain
  ///   multiple query representations for comprehensive cache coverage.
  /// </remarks>
  public GeoDataPointToEntityQuery? GeoDataPointToEntityQuery { get; set; }
}
namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a query for retrieving detailed geographic data for a specific entity.
/// </summary>
/// <remarks>
///   This interface defines a query specification used to retrieve
///   comprehensive geographic information for a specific entity from mapping services or geographic data providers.
///   The query targets a single geographic entity identified by its unique identifier (<see cref="EntityId"/>) and
///   optionally filtered by entity type (<see cref="EntityType"/>), requesting detailed data including boundaries,
///   coordinates, names, and other geographic properties. This query mechanism supports map-based charts that need
///   to display specific geographic regions with accurate boundaries and positioning. The query results typically
///   include <see cref="GeoData"/> containing the entity's bounding box, detailed boundary polygons, identification
///   information, and copyright attributions. These results are stored in <see cref="GeoDataEntityQueryResults"/>
///   within the <see cref="Clear"/> structure, which can be cached in <see cref="GeoCache"/> for offline access and
///   performance optimization. Geographic entity queries are essential for map chart initialization, where the chart
///   needs to load the geographic definitions for all regions that will be visualized. Common scenarios include
///   querying for country boundaries when creating a world map visualization, requesting state boundaries for regional
///   analysis, or retrieving custom geographic entity definitions for specialized domains. The query enables efficient
///   data retrieval by targeting specific entities rather than loading entire geographic datasets, supporting
///   on-demand loading of geographic information as needed for chart rendering and interaction. The entity type
///   filter helps disambiguate entities that might have the same identifier across different classification levels
///   (such as "Georgia" the country vs. "Georgia" the U.S. state), ensuring the correct entity data is retrieved.
/// </remarks>
public interface GeoDataEntityQuery
{
  /// <summary>
  ///   Gets or sets the type classification of the geographic entity being queried.
  /// </summary>
  /// <remarks>
   ///   The entity type specifies the classification level or category of the geographic entity, helping to
  ///   disambiguate entities and ensure the correct entity is retrieved when identifiers might be ambiguous.
  ///   Entity types typically correspond to administrative levels (such as country, state/province, county/district)
  ///   or geographic classifications (such as populated place, statistical region, postal code area). For example,
  ///   specifying the entity type as "Country" when querying for "Georgia" ensures the query returns data for the
  ///   country of Georgia rather than the U.S. state. The entity type works in conjunction with <see cref="EntityId"/>
  ///   to provide precise entity identification, particularly in geographic data systems where entity identifiers
  ///   may not be globally unique across all entity types. When no entity type is specified, the query relies solely
  ///   on the entity ID, which may require the ID to be uniquely qualified or may return the most common entity
  ///   matching that identifier based on the provider's default resolution logic.
  /// </remarks>
  public EntityTypeEnum? EntityType { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier of the geographic entity to retrieve.
  /// </summary>
  /// <remarks>
   ///   The entity identifier uniquely references the specific geographic entity for which detailed data is being
  ///   requested. Entity identifiers typically follow standardized formats such as ISO country codes (e.g., "US",
  ///   "GB", "JP" for countries), administrative division codes, or provider-specific entity references. The
  ///   identifier format depends on the geographic data provider specified in <see cref="GeoCache.Provider"/>,
  ///   ensuring consistency with the provider's entity identification system. For example, querying for "US" with
  ///   an entity type of "Country" would retrieve comprehensive geographic data for the United States, including
  ///   its bounding box, boundary polygons, and other properties. The entity ID enables precise targeting of
  ///   specific geographic regions for data retrieval, supporting efficient loading of only the entities needed
  ///   for the current map chart visualization. When combined with <see cref="EntityType"/>, the identifier provides
  ///   unambiguous entity reference, ensuring the query retrieves the correct geographic data even when multiple
  ///   entities might share similar identifiers across different classification levels.
  /// </remarks>
  public string? EntityId { get; set; }
}
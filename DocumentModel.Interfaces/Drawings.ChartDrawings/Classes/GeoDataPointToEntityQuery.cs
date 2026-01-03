namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a query for mapping a data point to its containing geographic entity by entity reference.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a query specification used to associate a
///   chart data point with a specific geographic entity through entity identification rather than coordinate-based
///   lookup. Unlike <see cref="GeoDataPointQuery"/> which uses latitude/longitude coordinates to find containing
///   entities, this interface directly references a target entity through its identifier (<see cref="EntityId"/>)
///   and optional type (<see cref="EntityType"/>), establishing an explicit association between a data point and
///   a geographic region. This mechanism is essential for map-based charts where data points are already associated
///   with known geographic entities (such as sales data by country, demographics by state, or metrics by region)
///   and need to be mapped to their geographic representations for visualization. The query enables efficient
///   data-to-geography binding without requiring coordinate lookups or reverse geocoding operations. The results
///   are typically stored in <see cref="GeoDataPointToEntityQueryResults"/> within the <see cref="Clear"/> structure,
///   which can be cached in <see cref="GeoCache"/> for offline access and performance optimization. This direct
///   entity reference approach is particularly valuable when working with pre-categorized data where each data point
///   is already labeled with its geographic identifier (such as country codes in sales records, state abbreviations
///   in demographic data, or region names in business metrics). Common scenarios include mapping sales figures to
///   countries by ISO code, associating population data with states by identifier, or linking performance metrics
///   to custom geographic regions by region ID. The entity type filter helps disambiguate cases where the same
///   identifier might exist at different administrative levels, ensuring the data point is mapped to the correct
///   geographic entity. This query-based mapping enables flexible, efficient data visualization on map charts
///   where geographic associations are known and explicit rather than derived from coordinates.
/// </remarks>
public interface GeoDataPointToEntityQuery : IModelElement
{
  /// <summary>
  ///   Gets or sets the type classification of the target geographic entity.
  /// </summary>
  /// <value>
  ///   An <see cref="EntityTypeEnum"/> value specifying the entity's classification level,
  ///   or <c>null</c> if no type filter is specified.
  /// </value>
  /// <remarks>
   ///   The entity type specifies the administrative or geographic classification level of the target entity,
  ///   helping to disambiguate cases where entity identifiers might not be unique across different classification
  ///   levels. For example, "GA" could refer to either Georgia the U.S. state or Georgia the country, and specifying
  ///   the entity type (such as "AdminDivision1" for state or "Country" for nation) ensures the data point is
  ///   mapped to the correct geographic entity. The entity type works in conjunction with <see cref="EntityId"/>
  ///   to provide precise entity identification, ensuring accurate data-to-geography mapping for chart visualization.
  ///   When no entity type is specified, the query relies solely on the entity identifier, which may require the
  ///   ID to be uniquely qualified or may use the provider's default entity resolution logic to select the most
  ///   appropriate entity matching that identifier.
  /// </remarks>
  public EntityTypeEnum? EntityType { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier of the target geographic entity.
  /// </summary>
  /// <value>
  ///   A string containing the entity's unique identifier,
  ///   or <c>null</c> if no entity is specified.
  /// </value>
  /// <remarks>
   ///   The entity identifier specifies the target geographic entity to which the data point should be mapped.
  ///   Entity identifiers typically follow standardized formats such as ISO country codes (e.g., "US", "GB", "JP"),
  ///   administrative division codes (e.g., "CA" for California, "NY" for New York), or custom region identifiers
  ///   defined by the organization or mapping provider. The identifier enables direct association between data points
  ///   and geographic entities, supporting efficient data visualization without requiring coordinate-based lookups.
  ///   For example, sales data with a "country" field containing "US" can be directly mapped to the United States
  ///   entity, or demographic data with state codes can be immediately associated with the corresponding state entities.
  ///   The entity ID format depends on the geographic data provider specified in <see cref="GeoCache.Provider"/>,
  ///   ensuring consistency with the provider's entity identification system. When combined with <see cref="EntityType"/>,
  ///   the identifier provides unambiguous entity reference, enabling precise data-to-geography mapping for accurate
  ///   map chart visualization.
  /// </remarks>
  public string? EntityId { get; set; }
}
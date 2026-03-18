namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a query for mapping a data point to its containing geographic entity by entity reference.
/// </summary>
/// <remarks>
///   This class defines a query specification used to associate a
///   chart data point with a specific geographic entity through entity identification rather than coordinate-based
///   lookup. Unlike <see cref = "GeoDataPointQuery"/> which uses latitude/longitude coordinates to find containing
///   entities, this class directly references a target entity through its identifier (<see cref = "EntityId"/>)
///   and optional type (<see cref = "EntityType"/>), establishing an explicit association between a data point and
///   a geographic region. This mechanism is essential for map-based charts where data points are already associated
///   with known geographic entities (such as sales data by country, demographics by state, or metrics by region)
///   and need to be mapped to their geographic representations for visualization. The query enables efficient
///   data-to-geography binding without requiring coordinate lookups or reverse geocoding operations. The results
///   are typically stored in <see cref = "GeoDataPointToEntityQueryResults"/> within the <see cref = "Clear"/> structure,
///   which can be cached in <see cref = "GeoCache"/> for offline access and performance optimization. This direct
///   entity reference approach is particularly valuable when working with pre-categorized data where each data point
///   is already labeled with its geographic identifier (such as country codes in sales records, state abbreviations
///   in demographic data, or region names in business metrics). Common scenarios include mapping sales figures to
///   countries by ISO code, associating population data with states by identifier, or linking performance metrics
///   to custom geographic regions by region ID. The entity type filter helps disambiguate cases where the same
///   identifier might exist at different administrative levels, ensuring the data point is mapped to the correct
///   geographic entity. This query-based mapping enables flexible, efficient data visualization on map charts
///   where geographic associations are known and explicit rather than derived from coordinates.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoDataPointToEntityQuery))]
public class GeoDataPointToEntityQuery: ModelElement<DXO16DCD.GeoDataPointToEntityQuery>
{
  /// <summary>
  /// Specifies the entity type.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoDataPointToEntityQuery.EntityType))]
  public EntityTypeEnum? EntityType
  {
    get => _EntityType;
    set => UpdateField(ref _EntityType, value, nameof(EntityType));
  }

  private EntityTypeEnum? _EntityType;

  /// <summary>
  /// Specifies the entity id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoDataPointToEntityQuery.EntityId))]
  public string? EntityId { get => _EntityId; set => UpdateField(ref _EntityId, value, nameof(EntityId)); }

  private string? _EntityId;
}
using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a query for retrieving detailed geographic data for a specific entity.
/// </summary>
/// <remarks>
///   This class defines a query specification used to retrieve
///   comprehensive geographic information for a specific entity from mapping services or geographic data providers.
///   The query targets a single geographic entity identified by its unique identifier (<see cref = "EntityId"/>) and
///   optionally filtered by entity type (<see cref = "EntityType"/>), requesting detailed data including boundaries,
///   coordinates, names, and other geographic properties. This query mechanism supports map-based charts that need
///   to display specific geographic regions with accurate boundaries and positioning. The query results typically
///   include <see cref = "GeoData"/> containing the entity's bounding box, detailed boundary polygons, identification
///   information, and copyright attributions. These results are stored in <see cref = "GeoDataEntityQueryResults"/>
///   within the <see cref = "Clear"/> structure, which can be cached in <see cref = "GeoCache"/> for offline access and
///   performance optimization. Geographic entity queries are essential for map chart initialization, where the chart
///   needs to load the geographic definitions for all regions that will be visualized. Common scenarios include
///   querying for country boundaries when creating a world map visualization, requesting state boundaries for regional
///   analysis, or retrieving custom geographic entity definitions for specialized domains. The query enables efficient
///   data retrieval by targeting specific entities rather than loading entire geographic datasets, supporting
///   on-demand loading of geographic information as needed for chart rendering and interaction. The entity type
///   filter helps disambiguate entities that might have the same identifier across different classification levels
///   (such as "Georgia" the country vs. "Georgia" the U.S. state), ensuring the correct entity data is retrieved.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoDataEntityQuery))]
public class GeoDataEntityQuery: ModelElement<DXO16DCD.GeoDataEntityQuery>
{
  /// <summary>
  /// Specifies the entity type.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoDataEntityQuery.EntityType))]
  public EntityTypeEnum? EntityType
  {
    get => _EntityType;
    set => UpdateField(ref _EntityType, value, nameof(EntityType));
  }
  private EntityTypeEnum? _EntityType;
  /// <summary>
  /// Specifies the entity id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoDataEntityQuery.EntityId))]
  public string? EntityId { get => _EntityId; set => UpdateField(ref _EntityId, value, nameof(EntityId)); }
  private string? _EntityId;
}